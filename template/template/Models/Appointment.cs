using System;
using System.Collections.Generic;

namespace template.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public int? NurseId { get; set; }

    public int? WardId { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    public DateTime? AdmitDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string? Notes { get; set; }

    public int AppointmentStatus { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Nurse? Nurse { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual Ward? Ward { get; set; }
}
