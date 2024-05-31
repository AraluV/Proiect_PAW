using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    public class PolitaDeAsigurare
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Asigurare Asigurare { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
    }
}
