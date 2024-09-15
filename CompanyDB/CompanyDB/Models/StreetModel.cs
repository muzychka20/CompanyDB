using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public class StreetModel
    {
        private int streetId;
        private string streetName;

        public int StreetID { get => streetId; set => streetId = value; }
        public string StreetName { get => streetName; set => streetName = value; }

        public override string ToString()
        {
            return StreetName;
        }
    }
}
