using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string CNIC { get; set; }
    }
}
