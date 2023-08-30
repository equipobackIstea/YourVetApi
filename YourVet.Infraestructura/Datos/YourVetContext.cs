using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace YourVet.Infraestructura.Datos;

public partial class YourVetContext : DbContext
{
    public YourVetContext()
    {

    }

    public YourVetContext(DbContextOptions<YourVetContext> options): base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=YourVet;Integrated Security = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
