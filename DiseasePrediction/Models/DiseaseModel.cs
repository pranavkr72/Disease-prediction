using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiseasePrediction.Models
{
    public class DiseaseModel
    {
        public SevereityModel Severity { get; set; }
        public CauseModel Cause { get; set; }
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string symptom { get; set; }
        public string DiseaseDescription { get; set; }
        public List<SymptomModel> symptoms { get; set; }
    }
}