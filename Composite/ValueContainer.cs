using System;
using System.Collections;
using System.Collections.Generic;

  namespace DesignPatterns.Composite
  {
    ///Consider the code presented below. The <code>Sum()</code> extension method adds up all the values 
    ///in a list of <code>IValueContainer</code> elements it gets passed. 
    ///We can have a single value or a set of values.
    ///Complete the implementation of the interfaces so that <code>Sum()</code> begins to work correctly.

    public interface IValueContainer : IEnumerable<IValueContainer>
    {
      
    }

    public class SingleValue : IValueContainer
    {
      public int Value;

      public IEnumerator<IValueContainer> GetEnumerator()
      {
          yield return this;
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
          return GetEnumerator();
      }

      public static int operator +(int n1, SingleValue n2)
      {
        return n1 + n2.Value;
      }
    }

    public class ManyValues : List<int>, IValueContainer
    {
      public new IEnumerator<IValueContainer> GetEnumerator()
      {
          return GetEnumerator();
      }
    }

    public static class ExtensionMethods
    {
      public static int Sum(this List<IValueContainer> containers)
      {
        int result = 0;
        foreach (var c in containers)
          foreach (var i in c)
            result += result;
            
        return result;
      }
    }
  }
