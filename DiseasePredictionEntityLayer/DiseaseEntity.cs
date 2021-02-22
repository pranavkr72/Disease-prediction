using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseasePredictionBusinessLayer
{
    public class DiseaseEntity
    {
        public SeverityEntity Severity { get; set; }
        public CauseEntity Cause{ get; set; }
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string symptom { get; set; }
        public string DiseaseDescription { get; set; }
        public List<SymptomsEntity> symptoms { get; set; }
    }
}
    