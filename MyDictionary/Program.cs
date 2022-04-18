using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> City = new MyDictionary<string>();
            City.Add("Ankara");
            City.Add("İstanbul");
            City.Add("İzmir");

        }
    }
}
