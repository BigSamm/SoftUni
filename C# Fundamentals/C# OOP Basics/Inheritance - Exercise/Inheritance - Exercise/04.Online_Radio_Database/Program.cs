using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var songs = new List<Song>();

        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var songList = Console.ReadLine().Split(';');
            try
            {
                ValidateSong(songList);

                var song = CreateSong(songList);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine($"Songs added: {songs.Count}");
        string allSongsLength = TakeAllLength(songs);
        Console.WriteLine($"Playlist length: {allSongsLength}");
    }

    private static string TakeAllLength(List<Song> songs)
    {
        long sec = 0;
        songs.ForEach(s => sec += s.AllLengthInSec);

        long min = sec / 60;
        sec %= 60;

        var hours = min / 60;
        min %= 60;

        return $"{hours}h {min}m {sec}s";
    }

    private static Song CreateSong(string[] songList)
    {
        var artistName = songList[0];
        var songName = songList[1];

        ValidateSongLength(songList);
        var songLegthList = songList[2].Split(':');
        var songMinutes = int.Parse(songLegthList[0]);
        var songSeconds = int.Parse(songLegthList[1]);

        var song = new Song(artistName, songName, songMinutes, songSeconds);
        return song;
    }

    private static void ValidateSongLength(string[] songList)
    {
        var lengthList = songList[2].Split(':');
        foreach (var item in lengthList)
        {
            var isDigit = int.TryParse(item, out int value);
            if (!isDigit)
                throw new ArgumentException("Invalid song length.");
        }
    }

    private static void ValidateSong(string[] songList)
    {
        if (songList.Length != 3)
            throw new ArgumentException("Invalid song.");

        //if (String.IsNullOrWhiteSpace(songList[0]) || String.IsNullOrWhiteSpace(songList[1]))
        //    throw ex;
    }
}
