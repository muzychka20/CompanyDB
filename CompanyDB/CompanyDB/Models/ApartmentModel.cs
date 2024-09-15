using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public class ApartmentModel
    {
        private int apartmentId;
        private string apartmentNumber;
        private string apartmentFloorNumber;

        public int ApartmentID { get => apartmentId; set => apartmentId = value; }
        public string ApartmentNumber { get => apartmentNumber; set => apartmentNumber = value; }
        public string ApartmentFloorNumber { get => apartmentFloorNumber; set => apartmentFloorNumber = value; }
        public string DisplayApartmentInfo => $"{ApartmentNumber} (Floor: {ApartmentFloorNumber})";
    }
}
