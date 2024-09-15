using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public class CityModel
    {
        private int cityId;
        private string cityName;

        public int CityID { get => cityId; set => cityId = value; }
        public string CityName { get => cityName; set => cityName = value; }

        public override string ToString()
        {
            return CityName;
        }
    }
}
