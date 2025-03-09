using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class SmtpConfig
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Host { get; set; }

    public int? Port { get; set; }

    public bool? EnableSsl { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Registration? User { get; set; }
}
