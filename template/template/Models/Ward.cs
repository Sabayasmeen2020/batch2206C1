using System;
using System.Collections.Generic;

namespace template.Models;

public partial class Ward
{
    public int WardId { get; set; }

    public string WardName { get; set; } = null!;

    public int BedCount { get; set; }

    public string? AvailableEquipment { get; set; }

    public string? WardDescription { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
