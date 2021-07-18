using System;
using System.Text;

namespace HW_1._1
{
    class Song
    {
        public string Name { get ; set ; }
        public string Author { get; set; }
        public int Year { get; set; }

        public void CreateSong()
            {
                Console.WriteLine("Input name of song");
                Name = Console.ReadLine();
                Console.WriteLine("Input author of song");
                Author = Console.ReadLine();
                Console.WriteLine("Input year of song");
                Year = Convert.ToInt32(Console.ReadLine());
            }
        }
    }