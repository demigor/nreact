using System;
using System.Linq.Expressions;

namespace NReact
{
  public delegate object NCtor();
  public delegate void NSetter(object target, object value);

  public class NTypeFactory
  {
    public readonly Type Type;
    public readonly NCtor Ctor;
    NSetter[] _setters = new NSetter[32];
    NFastRWLock _settersLock = new NFastRWLock();
    int _version;

    static NSetter NotSupported = (target, value) => { };

    public NTypeFactory(Type type, NCtor ctor)
    {
      Type = type;
      Ctor = ctor;
    }

    public NSetter this[int id, NFactory factory]
    {
      get
      {
        int version;

        _settersLock.EnterReadLock();
        try
        {
          if (id < _setters.Length)
          {
            var result = _setters[id];
            if (result != null)
              return Check(result);
          }
          version = _version;
        }
        finally
        {
          _settersLock.ExitReadLock();
        }

        _settersLock.EnterWriteLock();
        try
        {
          if (_version != version)
          {
            if (id < _setters.Length)
            {
              var result = _setters[id];
              if (result != null)
                return Check(result);
            }
          }

          if (_setters.Length <= id)
            Array.Resize(ref _setters, ((id + 31) >> 4) << 4);

          {
            var result = factory.ResolveSetter(Type, id);
            _setters[id] = result ?? NotSupported;

            _version++;

            return result;
          }
        }
        finally
        {
          _settersLock.ExitWriteLock();
        }
      }
    }

    static NSetter Check(NSetter result)
    {
      if (result == NotSupported)
        return null;

      return result;
    }
    /*
        public NCtor Ctor
        {
          get
          {
            var result = Ctor;

            if (result == null)
              lock (this)
              {
                if (Ctor != null)
                  return Ctor;

                return Ctor = CreateCtor(Type);
              }

            return result;
          }
        }

        static NCtor CreateCtor(Type type)
        {
    #if NOEMIT || (!DEBUG && WINDOWS_UWP)
          return () => Activator.CreateInstance(type);
    #else
          return Expression.Lambda<NCtor>(Expression.Convert(Expression.New(type), typeof(object))).Compile();
    #endif
        }
    */
  }

  public class NTypeFactory<T> : NTypeFactory where T : new()
  {
    public static readonly NTypeFactory Default = new NTypeFactory<T>();

    NTypeFactory() : base(typeof(T), CreateCtor()) { }

    static NCtor CreateCtor()
    {
#if NOEMIT || (!DEBUG || WINDOWS_UWP)
      return () => new T();
#else
      return Expression.Lambda<NCtor>(Expression.Convert(Expression.New(typeof(T)), typeof(object))).Compile();
#endif
    }
  }
}
