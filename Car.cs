using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    internal class Car
    {
        private int Id { get; set; }
        private string Brand { get; set; }
        private string Type { get; set; }
        private string License_Number { get; set; }
        private DateTime ReleaseDate { get; set; }  // Új DateTime tulajdonság

        // Getter és setter metódusok
        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public string GetLicenseNumber()
        {
            return License_Number;
        }

        public void SetLicenseNumber(string licenseNumber)
        {
            License_Number = licenseNumber;
        }

        // Getter és setter a ReleaseDate-hez
        public DateTime GetReleaseDate()
        {
            return ReleaseDate;
        }

        public void SetReleaseDate(DateTime releaseDate)
        {
            ReleaseDate = releaseDate;
        }
    }
}
