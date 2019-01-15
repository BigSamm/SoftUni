using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private const int MIN_NAME_LENGTH = 3;
    private const int MIN_LENGTH = 0;
    private const int MAX_MINUTES = 14;
    private const int MAX_SECONDS = 59;
    //private const int MAX_LENGTH = MAX_MINUTES * 60 + MAX_SECONDS;

    private string artistName;
    private string name;
    private int minutesLength;
    private int secondsLength;
    private int allLengthInSec;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        ArtistName = artistName;
        Name = songName;
        MinutesLength = minutes;
        SecondsLength = seconds;
        AllLengthInSec = CalculateAllLength(minutes, seconds);
    }
    
    public int AllLengthInSec
    {
        get { return allLengthInSec; }
        private set
        {
            //if (value < MIN_LENGTH || value > MAX_LENGTH)
            //    throw new ArgumentException("Invalid song length.");
            allLengthInSec = value;
        }
    }

    public int SecondsLength
    {
        get { return secondsLength; }
        private set
        {
            if (value < MIN_LENGTH || value > MAX_SECONDS)
                throw new ArgumentException($"Song seconds should be between {MIN_LENGTH} and {MAX_SECONDS}.");
            secondsLength = value;
        }
    }

    public int MinutesLength
    {
        get { return minutesLength; }
        private set
        {
            if (value < MIN_LENGTH || value > MAX_MINUTES)
                throw new ArgumentException($"Song minutes should be between {MIN_LENGTH} and {MAX_MINUTES}.");
            minutesLength = value;
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            var maxSongNameLength = 30;
            if (value.Length < MIN_NAME_LENGTH || value.Length > maxSongNameLength)
                throw new ArgumentException($"Song name should be between {MIN_NAME_LENGTH} and {maxSongNameLength} symbols.");

            name = value;
        }
    }

    public string ArtistName
    {
        get { return artistName; }
        private set
        {
            var maxArtistNameLength = 20;
            if (value.Length < MIN_NAME_LENGTH || value.Length > maxArtistNameLength)
                throw new ArgumentException($"Artist name should be between {MIN_NAME_LENGTH} and {maxArtistNameLength} symbols.");

            artistName = value;
        }
    }

    private int CalculateAllLength(int minutes, int seconds)
    {
        return minutes * 60 + seconds;
    }
}
