using System;
using Carpark.MusicStore;

namespace Carpark
{
    class Program
    {
        private static void Main()
        {
            Store store = new Store("Cool Store", "5th Avenue, New York");
           
            store = store + new Audio("Three Days Grace", "RC1", 5, "Rock", "Disk1");
            store = store + new Audio("Arctic Monkeys", "AM", 10, "Alternative", "AM");

            store = store + new DVD("Producer 1", "Some Company", 182, "Amazing Movie", "Fantasy");
            store = store + new DVD("Producer 2", "Another Company", 129, "Nice Movie", "Documentary");

            Console.WriteLine(store.ToString());
            
            store.DVDs[0].Burn("BURNED producer", "BURNED FilmCompany", "500");

            Console.WriteLine();
            foreach (var dvd in store.DVDs)
                Console.WriteLine($"{dvd.GetName()} -> {dvd.DiskSize}");
       
            foreach (var audio in store.Audios)
                Console.WriteLine($"{audio.GetName()} -> {audio.DiskSize}");
        }
    }
}