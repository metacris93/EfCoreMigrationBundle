using System;
using System.ComponentModel.DataAnnotations;

namespace EfCoreMigrationBundle.Entities;

public class Person
{
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}

