﻿namespace CleanArchitecture.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
    }
}
