using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ImageIcon { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
