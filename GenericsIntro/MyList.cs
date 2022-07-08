using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
       T[] list;
       public MyList()
       {
            list = new T[0];
       }
       public void Add (T input)
       {
           T[] alterArray = list;
           list = new T[list.Length + 1];
           for (int i = 0; i < alterArray.Length; i++)
           {
                list[i] = alterArray[i];
           }
           list[list.Length - 1] = input;
       }
       public int Count()
       {
            return list.Length;
       }
    }
}
