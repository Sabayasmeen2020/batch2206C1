using System;
using System.Collections.Generic;

namespace template.Models;

public partial class MedicalRecord
{
    public int MedicalRecordId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctoId { get; set; }

    public int? PrescriptionId { get; set; }

    public int? Diagnosis { get; set; }

    public string? Treatment { get; set; }

    public string Allergy { get; set; } = null!;

    public string? Procedur { get; set; }

    public virtual Disease? DiagnosisNavigation { get; set; }

    public virtual Doctor? Docto { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual Prescription? Prescription { get; set; }
}
