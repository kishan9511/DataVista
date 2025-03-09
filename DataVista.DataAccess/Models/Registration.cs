using System;
using System.Collections.Generic;

namespace DataVista.DataAccess.Models;

public partial class Registration
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? AddedData { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<AppInfo> AppInfos { get; set; } = new List<AppInfo>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<LoginActivity> LoginActivities { get; set; } = new List<LoginActivity>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<SmtpConfig> SmtpConfigs { get; set; } = new List<SmtpConfig>();
}
