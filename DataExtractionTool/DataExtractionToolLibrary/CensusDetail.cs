using System;
using System.Collections.Generic;
using System.Text;

namespace DataExtractionToolLibrary
{
    public class CensusDetail
    {
        public string Patient { get; set; }
        public string PayerType { get; set; }

        public string PayingAgency { get; set; }

        public string MRN { get; set; }

        public string AdmitDate { get; set; }

        public string PTSOC { get; set; }

        public string PTEOC { get; set; }

        public string OTSOC { get; set; }

        public string OTEOC { get; set; }

        public string STSOC { get; set; }
        
        public string STEOC { get; set; }

        public string NTSOC { get; set; }

        public string NTEOC { get; set; }
    }
}
