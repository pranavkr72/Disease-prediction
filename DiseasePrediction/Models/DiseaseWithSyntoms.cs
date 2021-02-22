using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiseasePrediction.Models
{
    public class DiseaseWithSyntoms
    {
        public int DSID { get; set; }
        public DiseaseModel Disease { get; set; }
        public SymptomModel Symptom { get; set; }
        public string Description { get; set; }
    }
}