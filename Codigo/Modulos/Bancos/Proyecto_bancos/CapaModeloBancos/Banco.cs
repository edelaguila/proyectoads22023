using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloBancos
{
    public class Banco
    {
        public int ban_id_Banco { get; set; }
        public string fk_ban_Nombre_banco { get; set; }
        public string ban_status { get; set; }

        // Constructor
        public Banco(int idBanco, string nombreBanco, string status)
        {
            ban_id_Banco = idBanco;
            fk_ban_Nombre_banco = nombreBanco;
            ban_status = status;
        }
    }


}
