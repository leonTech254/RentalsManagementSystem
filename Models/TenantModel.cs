using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalManagementSystem.Client.Models
{
    public class TenantModel
    {
        public int Id {get;set;}
        public String Firstname {get;set;}
        public String Lastname {get;set;}
        public String email {get;set;}
        public String houseNumber {get;set;}
    }
}