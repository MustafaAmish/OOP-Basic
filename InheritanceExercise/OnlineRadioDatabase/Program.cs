using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OnlineRadioDatabase
{
    class Program
    {
        private const int Min_SongLenght = 0;
        private const int Max_SongLenght = 899;


        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            var songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    var inputSong = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                    if (inputSong.Length<3||inputSong.Length>3)
                    {
                        throw new ArgumentException($"Invalid song.");
                    }
                    var artistName = inputSong[0];
                    var songName = inputSong[1];
                    string pattern = @"^\d+:\d+";
                    Regex rgx = new Regex(pattern);
                    if (!rgx.IsMatch(inputSong[2]))
                    {
                        throw new ArgumentException($"Invalid song length.");
                    }
                    var songLenght = inputSong[2].Split(':').Select(int.Parse).ToArray();
                    //var totalTIme = songLenght[0] * 60 + songLenght[1];
                   
                    var song=new Song(artistName,songName,songLenght[0],songLenght[1]);
                    songs.Add(song);
                    Console.WriteLine($"Song added.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                   
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");

            var totalSeconds = songs.Select(s => s.Seconds).Sum();
            var secondsToMinutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            var totalMinutes = songs.Select(s => s.Minuts).Sum() + secondsToMinutes;
            var minutesToHours = totalMinutes / 60;
            var minutes = totalMinutes % 60;

            var hours = minutesToHours;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
