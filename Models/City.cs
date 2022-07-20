using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class City
        

    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PostalCode { get; set; }
    }
}
