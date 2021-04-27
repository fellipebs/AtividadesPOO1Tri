using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Casa_de_showBLL : PontoTuristicoBLL
    {
        private DateTime data_inicio;
        private string dia_fecha;

        public DateTime Data_inicio { get => data_inicio; set => data_inicio = value; }
        public string Dia_fecha { get => dia_fecha; set => dia_fecha = value; }
    }
}
