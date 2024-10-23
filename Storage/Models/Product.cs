﻿namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
