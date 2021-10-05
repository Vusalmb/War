using System;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            Ak47 obj1 = new Ak47(300,50);
            Makar obj2 = new Makar();
            obj1.ShutAk47();
            obj2.ShutMakar();
        }
    }
}
