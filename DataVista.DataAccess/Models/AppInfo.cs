using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class AppInfo
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public string? Favicon { get; set; }

    public string? LoginBackgroundImage { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Registration? User { get; set; }
}
