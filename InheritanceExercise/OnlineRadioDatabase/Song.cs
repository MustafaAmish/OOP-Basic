using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private const int Min_NameLenght = 3;
    private const int Max_ArtistNameLenght = 20;
    private const int Max_SongNameLenght = 30;
    private const int Max_Minuts = 14;
    private const int Min_SecondAnd_Minuts = 0;
    private const int Max_Second = 59;

    private string artistName;
    private string songName;
    private int minuts;
    private int seconds;

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length<Min_NameLenght||value.Length>Max_ArtistNameLenght)
            {
                throw new ArgumentException($"Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length<Min_NameLenght||value.Length>Max_SongNameLenght)
            {
                throw new ArgumentException($"Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    public int Minuts
    {
        get { return minuts; }
        set
        {
            if (value<Min_SecondAnd_Minuts||value>Max_Minuts)
            {
                throw new ArgumentException($"Song minutes should be between 0 and 14.");
            }
            minuts = value;
        }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value<Min_SecondAnd_Minuts||value>Max_Second)
            {
                throw new ArgumentException($"Song seconds should be between 0 and 59.");
            }
            seconds = value;
        }
    }

    public Song(string artistName,string songName,int minuts,int seconds)
    {
        ArtistName = artistName;
        SongName = songName;
        Minuts = minuts;
        Seconds = seconds;
    }







}

