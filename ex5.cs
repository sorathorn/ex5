using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numitem, n;
            string itemname, itemtype;
            Console.Write("Number of item in the bag: ");
            n = int.Parse(Console.ReadLine());

            for (numitem = 1; numitem <= n; numitem++)
            {
                Console.WriteLine("Input item: ");
                itemname = Console.ReadLine();
                Console.WriteLine("Input type: ");
                itemtype = Console.ReadLine();
            }

            Console.WriteLine("Input ShowAll or ItemType: ");
            string showall = Console.ReadLine();

            if (showall == "ShowAll")
            {
                Console.Write("itemname {0}:itemtype {1}", itemname, itemtype);
                Console.WriteLine();
            }
            if (showall == "itemtype")
            {
                Console.Write("{0}", itemname);
                Console.WriteLine();
            }
            else
            {
                Console.Write("End");
            }
        }
    }
}
