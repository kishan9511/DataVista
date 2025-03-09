using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class LoginActivity
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? EventTypeId { get; set; }

    public DateTime? EventDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Registration? User { get; set; }
}
