﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CD : IComparable<CD>
    {
        private int id;
        private string album;
        private string singer;
        private int duration;
        private List<string> songList;
        private Genre genre;

        public CD()
        {
        }

        public CD(string album, int duration, Genre genre, int id, string singer, List<string> songList)
        {
            this.album = album;
            this.duration = duration;
            this.genre = genre;
            this.id = id;
            this.singer = singer;
            this.songList = songList;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public List<string> SongList
        {
            get { return songList; }
            set { songList = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int CompareTo(CD other)
        {
            return id.CompareTo(other.id);
        }

        public override string ToString()
        {
            return "ID: " + id
                   + " Album: " + album
                   + " Singer: " + singer
                   + " Duration: " + duration
                   + "\n List of Song: \n" + SongListToString()
                   + " Genre: " + genre;
        }

        private string SongListToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string s in songList)
            {
                builder.Append("\t"+s + "\n");
            }
            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            CD cd = obj as CD;
            if (cd != null)
            {
                return id == cd.id;
            }
            else
            {
                return base.Equals(obj);
            }
            
        }

    }
    

    enum Genre
    {
        Rock,
        Rap,
        Country,
        Blue,
        Jazz,
        Dance
    }
}
