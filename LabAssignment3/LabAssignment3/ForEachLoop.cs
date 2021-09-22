using System;


namespace LabAssignment3
{
    class ForEachLoop
    {
        static void Main()
        {
            int[] numsArray = { 2, 4,6,8 };
            foreach (var num in numsArray)
            {
                Console.Write($"{num}\t");
            }

            Console.ReadLine();
        }
    }
}
