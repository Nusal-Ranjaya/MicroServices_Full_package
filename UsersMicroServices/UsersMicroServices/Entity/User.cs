﻿namespace UsersMicroServices.Entity
{
    public class User
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Balance { get; set; }
    }
}