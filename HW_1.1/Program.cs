using System;
using System.Text.Json;

namespace HW_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.CreateSong();

            string json = JsonSerializer.Serialize(song);

            Console.WriteLine("");
            Console.WriteLine(json);
        }
    }
}