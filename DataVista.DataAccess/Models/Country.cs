using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CountryCode { get; set; }

    public string? ImgIcon { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
