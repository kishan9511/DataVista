using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class CityZipCode
{
    public int Id { get; set; }

    public int? CityId { get; set; }

    public string? Name { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual City? City { get; set; }
}
