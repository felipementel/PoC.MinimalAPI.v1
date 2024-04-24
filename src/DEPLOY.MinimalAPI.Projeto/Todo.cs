﻿using Microsoft.EntityFrameworkCore;

partial class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
    : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}

public class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}