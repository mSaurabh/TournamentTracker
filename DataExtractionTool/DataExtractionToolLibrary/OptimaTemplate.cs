using System;
using System.Collections.Generic;
using System.Text;

namespace DataExtractionToolLibrary
{
    public class OptimaTemplate
    {
        /// <summary>
        /// Censusdetail reports csv file information stored here.
        /// </summary>
        public List<CensusDetail> Census { get; set; } = new List<CensusDetail>();

        /// <summary>
        /// TherapyDiagnosis report csv file information stored here.
        /// </summary>
        public List<TherapyDiagnosis> TherapyDiagnosis { get; set; } = new List<TherapyDiagnosis>();
    }
}
