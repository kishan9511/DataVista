using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class EmailTemplate
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }

    public string? Template { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Registration? User { get; set; }
}
