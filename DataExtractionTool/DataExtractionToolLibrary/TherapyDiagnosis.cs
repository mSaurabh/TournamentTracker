using System;
using System.Collections.Generic;
using System.Text;

namespace DataExtractionToolLibrary
{
    public class TherapyDiagnosis
    {
        public string Patient { get; set; }

        public string Discipline { get; set; }

        public string PayerType { get; set; }

        public string PayerPlan { get; set; }

        public string CertFromDate { get; set; }

        public string MedicalDiagOnsetDate { get; set; }

        public string TreatmentDiagOnsetDate { get; set; }

        public string CPT { get; set; }

        public string Frequency { get; set; }

        public string Duration { get; set; }
    }
}
