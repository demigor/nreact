using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NReact
{
  partial class NFactory
  {
#if NOEMIT
    public object CreateInstance(Type type)
    {
      return Activator.CreateInstance(type);
    }
#else
    NFastRWLock _typeFactoriesLock = new NFastRWLock();
    Dictionary<Type, NTypeFactory> _typeFactories = new Dictionary<Type, NTypeFactory>();
    int _typeFactoriesVersion;

    internal NTypeFactory GetTypeFactory(Type type)
    {
      NTypeFactory result;
      int version;

      _typeFactoriesLock.EnterReadLock();
      try
      {
        if (_typeFactories.TryGetValue(type, out result))
          return result;

        version = _typeFactoriesVersion;
      }
      finally
      {
        _typeFactoriesLock.ExitReadLock();
      }

      _typeFactoriesLock.EnterWriteLock();
      try
      {
        if (_typeFactoriesVersion != version && _typeFactories.TryGetValue(type, out result))
          return result;

        _typeFactories[type] = result = CreateTypeFactorySlow(type);

        _typeFactoriesVersion++;

      }
      finally
      {
        _typeFactoriesLock.ExitWriteLock();
      }
      return result;
    }

    NTypeFactory CreateTypeFactorySlow(Type type)
    {
      return (NTypeFactory)typeof(NTypeFactory<>).MakeGenericType(type).GetStaticFieldValue("Default");
    }

    public object CreateInstance(Type type)
    {
      return GetTypeFactory(type).Ctor();
    }

    public object CreateInstance<T>() where T : new()
    {
      return NTypeFactory<T>.Default.Ctor();
    }
#endif
  }
}
