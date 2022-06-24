using System;
using System.Collections.Generic;

namespace Hello_world
{
    class Lists
    {
        public void ListsMain()
        {
            var nums = new List<int>();
            var nums2 = new List<int> { 1, 2, 3, 4 };

            List<string> words = new List<string> {"Hola", "Adios"};

            nums2.Sort();
            nums2.RemoveRange(2,2);

            bool check = nums2.Contains(1);
            int index = nums2.FindIndex(x => x == 1);
            Console.WriteLine(index);
            nums2.ForEach(i => Console.WriteLine(i));
        }
    }
}