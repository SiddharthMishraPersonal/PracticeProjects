using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine(ColumnLabel(8));
      Console.WriteLine(ColumnLabel(26));
      Console.WriteLine(ColumnLabel(28));
      Console.WriteLine(ColumnLabel(29));
      Console.WriteLine(ColumnLabel(30));
      Console.WriteLine(ColumnLabel(52));
      Console.WriteLine(ColumnLabel(53));
      Console.WriteLine(ColumnLabel(54));
      Console.WriteLine(ColumnLabel(78));
      Console.WriteLine(ColumnLabel(100));
      Console.WriteLine(ColumnLabel(123));

      
      Console.ReadKey();
    }




    private static Dictionary<int, string> _indexMappings = new Dictionary<int, string>()
    {
      {1, "A"},
      {2, "B"},
      {3, "C"},
      {4, "D"},
      {5, "E"},
      {6, "F"},
      {7, "G"},
      {8, "H"},
      {9, "I"},
      {10, "J"},
      {11, "K"},
      {12, "L"},
      {13, "M"},
      {14, "N"},
      {15, "O"},
      {16, "P"},
      {17, "Q"},
      {18, "R"},
      {19, "S"},
      {20, "T"},
      {21, "U"},
      {22, "V"},
      {23, "W"},
      {24, "X"},
      {25, "Y"},
      {26, "Z"},
    };


   static string ColumnLabel(int index)
    {
      if (index < 1)
        throw new ArgumentException("The index must be greater than 0", "index");

      var location = "";
      var remainder = 0;
     var dividend = 0;

      if (index < 27)
      {
        location = _indexMappings[index];
        return location;
      }

      remainder = index % 26;
      dividend = index / 26;

     
     if (remainder == 0)
     {
       for (int i = 0; i < dividend-1; i++)
       {
         location += "A";
       }
       location += "Z";
     }
     else
     {
       for (int i = 0; i < dividend; i++)
       {
         location += "A";
       }
       location += _indexMappings[remainder];

     }

     //do
      //{
      //  remainder = index % 26;
      //  dividend = index / 26;

      //  for (int i = 0; i < dividend; i++)
      //  {
      //    location += "A";
      //  }

      //  location += _indexMappings[remainder];

      //  if (remainder != 0)
      //  {
      //    var columnLabel = _indexMappings[remainder];
      //    location = string.Format("A{0}", columnLabel);
      //  }
      //} while (index != 0);


      return location;

    }
  }
}
