using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public class HouseModel
    {
        private int houseId;
        private string houseNumber;

        public int HouseID { get => houseId; set => houseId = value; }
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }

        public override string ToString()
        {
            return HouseNumber;
        }
    }
}
