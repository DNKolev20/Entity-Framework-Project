using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.DAL.Models;

public partial class Book
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Title { get; set; } = null!;

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public short Pages { get; set; }

    public int AuthorId { get; set; }

    public int GenreId { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Books")]
    public virtual Author Author { get; set; } = null!;

    [ForeignKey("GenreId")]
    [InverseProperty("Books")]
    public virtual Genre Genre { get; set; } = null!;
}
