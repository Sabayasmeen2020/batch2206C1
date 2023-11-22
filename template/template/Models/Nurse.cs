using System;
using System.Collections.Generic;

namespace template.Models;

public partial class Nurse
{
    public int NurseId { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? ContactInformation { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
