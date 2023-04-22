﻿namespace AnimeWebAPI.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Character> Characters { get; set; }
    }
}
