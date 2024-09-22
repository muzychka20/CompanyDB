using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public class CountryModel
    {
        private int countryId;
        private string countryName;

        public int CountryID { get => countryId; set => countryId = value; }
        public string CountryName { get => countryName; set => countryName = value; }       
    }
}
