using System;
using System.Collections.Generic;

namespace BelajarLooping
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MEMANGGIL BERBAGAI MACAM LOOPING ===");
            Console.WriteLine(); 

            ForLoop.Jalankan();
            ForeachLoop.Jalankan();
            WhileLoop.Jalankan();
            DoWhileLoop.Jalankan();
        }
    }
    class ForLoop
    {
        public static void Jalankan()
        {
            Console.WriteLine("--- Contoh For Loop ---");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Muncul i For ke-" + i);
            }
            Console.WriteLine();
        }
    }
    class ForeachLoop
    {
        public static void Jalankan()
        {
            Console.WriteLine("--- Contoh Foreach Loop ---");
            List<string> buahList = new List<string> { "Mangga", "Mengkudu", "Blueberry" };

            foreach (string buah in buahList)
            {
                Console.WriteLine("Buah: " + buah);
            }
            Console.WriteLine();
        }
    }
    class WhileLoop
    {
        public static void Jalankan()
        {
            Console.WriteLine("--- Contoh While Loop ---");
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("Muncul i While ke-" + i);
                i++;
            }
            Console.WriteLine(); 
        }
    }
    class DoWhileLoop
    {
        public static void Jalankan()
        {
            Console.WriteLine("--- Contoh Do-While Loop ---");
            int i = 1;
            do
            {
                Console.WriteLine("Muncul i Do-While ke-" + i);
                i++;
            } while (i <= 3);
            Console.WriteLine(); 
        }
    }
}