using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class DiseaseType
    {
        public int DiseaseTypeID { get; set; }
        public Disease Disease { get; set; }
    }
}
