using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NReact;

[TestClass]
public class CompareListTests
{
  [TestMethod]
  public void TestMove1()
  {
    CheckDiff(new[] { 1, 2, 3, 4, 5 },
              new[] { 1, 3, 4, 5, 2 });
  }

  [TestMethod]
  public void TestInsert1()
  {
    CheckDiff(new[] { 1 },
              new[] { 1, 2, 3, 4, 5 });
  }

  [TestMethod]
  public void TestInsert1M()
  {
    CheckDiff(new[] { 1, 3, 5 },
              new[] { 1, 2, 3, 4, 5 });
  }

  [TestMethod]
  public void TestInsert2()
  {
    CheckDiff(new int[0],
              new[] { 1, 2, 3, 4, 5 });
  }

  [TestMethod]
  public void TestDelete1()
  {
    CheckDiff(new[] { 1, 2, 3, 4, 5 },
              new[] { 1 });
  }

  [TestMethod]
  public void TestDelete1M()
  {
    CheckDiff(new[] { 1, 2, 3, 4, 5 },
              new[] { 1, 3, 5 });
  }

  [TestMethod]
  public void TestDelete2()
  {
    CheckDiff(new[] { 1, 2, 3, 4, 5 },
              new int[0]);
  }

  [TestMethod]
  public void TestReverse()
  {
    CheckDiff(new[] { 1, 2, 3, 4, 5 },
              new[] { 5, 4, 3, 2, 1 });
  }

  static DemoLogic logic = new DemoLogic();

  static void CheckDiff<T>(T[] left, T[] right)
  {
    var olds = ToElements(left);
    var news = ToElements(right);
    var diff = NPatch.DiffList(olds, news, logic);
    var list = new List<object>(from i in olds select logic.Create(i));

    if (diff != null)
      diff.ApplyList(list);

    Assert.IsTrue((from i in news select logic.Create(i)).SequenceEqual(list));
  }

  static NElement[] ToElements<T>(T[] left)
  {
    return (from i in left select new NElement { Type = typeof(T), Key = i }).ToArray();
  }

  class DemoLogic : NPatchLogic
  {
    public override object Create(NElement element)
    {
      return new DemoElement { Name = string.Concat(element.Key) };
    }

    public override void Destroy(NElement element, object uiElement)
    {

    }

    public override IList GetChildren(object uiElement)
    {
      return ((DemoElement)uiElement).Items;
    }
  }

  class DemoElement
  {
    public string Name;
    public List<DemoElement> Items = new List<DemoElement>();

    public override bool Equals(object obj)
    {
      var e = obj as DemoElement;

      if (e != null)
        return e.Name == Name && e.Items.SequenceEqual(Items);

      return false;
    }
  }
}
