using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseasePredictionBusinessLayer
{
    class DiseaseWithSymptom
    {
        public int DSID { get; set; }
        public  DiseaseEntity Disease { get; set; }
        public SymptomsEntity Symptom { get; set; }
        public string Description { get; set; }
    }
}
