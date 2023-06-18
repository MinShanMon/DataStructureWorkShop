using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure.Delimiters
{
    class Delimiters
  {
    public static void Run()
    {
      Console.WriteLine(IsBalanedDelimeter("a {b [c (d + e)/2 - f  ] + 1}"));
      Console.WriteLine(IsBalanedDelimeter("a {b [c (d + e)/2 - f  ] + 1"));
      Console.WriteLine(IsBalanedDelimeter("{a [b + (c + 2)/d ] + e) + f }"));
    }

    public static bool IsBalanedDelimeter(string expression)
    {
      //Keep a stack of open delimiters 
      Stack<char> openDelimiterStack = new Stack<char>();
    
      // and loop through all the characters inside expression
      foreach (char ch in expression)
      {
        //When facing an open delimiter, push it into the stack
        if (IsOpenDelimiter(ch))
        {
          openDelimiterStack.Push(ch);
        }
        //When facing a close delimiter,  paired
        else if (IsClosedDelimiter(ch))
        {
          // pop from the stack and check if the open parenthesis is correctly
          if (openDelimiterStack.Count > 0)
          {
            char openDelimiterFromStack = openDelimiterStack.Pop();
            // if (openDelimiterFromStack is not paired correctly with ch) {
            if (!IsPaired(openDelimiterFromStack, ch)) {
              return false;
            }
          }
          else
          {
            return false;
          }
        }
      }

      // If we reach here, i.e, end of expression

      // If there is no more open delimiter inside the stack
      if (openDelimiterStack.Count == 0)
        return true;
      // Else 
      else
        return false;
    }

    private static bool IsOpenDelimiter(char ch)
    {
      return ch == '(' || ch == '[' || ch == '{'; 
    }

    private static bool IsClosedDelimiter(char ch)
    {
      return ch == ')' || ch == ']' || ch == '}';
    }

    // Check openDelimiterFromStack is not paired correctly with closedDelimiter
    // Input: openDelimiterFromStack (char), closedDelimiter (char)
    // Output: return if openDelimiterFromStack is not paired correctly with closedDelimiter
    private static bool IsPaired(char openDelimiterFromStack, char closedDelimiter)
    {
      return (openDelimiterFromStack == '(' && closedDelimiter == ')') ||
          (openDelimiterFromStack == '[' && closedDelimiter == ']') ||
          (openDelimiterFromStack == '{' && closedDelimiter == '}');
    }


  }
}