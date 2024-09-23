using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string License_Number { get; set; }
        public DateTime ReleaseDate { get; set; }  // Új DateTime tulajdonság

        
    }
}
