using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class City
{
    public int Id { get; set; }

    public int? StateId { get; set; }

    public string? Name { get; set; }

    public string? ImgIcon { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CityZipCode> CityZipCodes { get; set; } = new List<CityZipCode>();

    public virtual State? State { get; set; }
}
