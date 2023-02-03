using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeChartDemo;
using System;
using System.Runtime.CompilerServices;

namespace PrimeChartDemo.UnitTests
{
  [TestClass]
  public class UnitTest_Methods
  {
    [TestMethod]
    public void TestMethod1(FormMain formMain)
    {
      var source1 = new List<int> { 2, 3, 5, 7, 9 };
      var expected = new Dictionary<int, int> { { 1, 5 } }; ;
      var result = formMain.CountPrimeNumberDizaine(source1);
      Assert.IsTrue(DictionariesAreEquivalent(expected, result));
    }

    private bool DictionariesAreEquivalent(Dictionary<int, int> expected, Dictionary<int, int> result)
    {
      if (expected.Count != result.Count)
      {
        return false;
      }

      foreach (var item in expected)
      {
        if (expected[item.Key] != result[item.Key])
        {
          return false;
        }
      }

      return true;
    }
  }
}
