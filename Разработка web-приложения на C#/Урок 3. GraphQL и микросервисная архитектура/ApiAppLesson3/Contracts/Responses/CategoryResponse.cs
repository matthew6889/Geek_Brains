﻿namespace ApiAppLesson3.Contracts.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
