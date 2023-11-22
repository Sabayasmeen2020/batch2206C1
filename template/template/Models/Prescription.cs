using System;
using System.Collections.Generic;

namespace template.Models;

public partial class Prescription
{
    public int PrescriptionId { get; set; }

    public string MedicationName { get; set; } = null!;

    public string Dosage { get; set; } = null!;

    public string? Instructions { get; set; }

    public string Ingredient { get; set; } = null!;

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}
