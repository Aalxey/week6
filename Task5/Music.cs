using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Music
    {
        public string Title { get; set; }
        public int DurationSeconds { get; set; }

        public Music(string title, int durationSeconds)
        {
            Title = title;
            DurationSeconds = durationSeconds;
        }
        internal static class MusicOperations
        {
            public static void DisplayElements(List<Music> songs)
            {
                var firstSong = songs.First();
                var lastSong = songs.Last();
                var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
                var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

                Console.WriteLine("Element Operators:");
                Console.WriteLine($"First Song: {firstSong.Title}");
                Console.WriteLine($"Last Song: {lastSong.Title}");
                Console.WriteLine($"First Song > 4 min: {firstAbove4Min.Title}");
                Console.WriteLine("First Song > 10 min: " +
                                  (firstAbove10Min != null ? firstAbove10Min.Title : "None"));
            }
        }
    }
}
