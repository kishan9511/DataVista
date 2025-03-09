using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class State
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? Name { get; set; }

    public string? ImgIcon { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country? Country { get; set; }
}
