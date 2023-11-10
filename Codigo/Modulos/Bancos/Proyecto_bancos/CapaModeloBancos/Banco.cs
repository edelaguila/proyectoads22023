using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloBancos
{
    public class Banco
    {
        public int pk_manag_id_ban { get; set; }
        public int manag_id_bancoag { get; set; }
        public string manag_nombre_banco { get; set; }
        public int manag_status { get; set; }
        public int manag_status_conciliacion { get; set; }

        public Banco(int pk_manag_id_ban, int manag_id_bancoag, string manag_nombre_banco, int manag_status, int manag_status_conciliacion)
        {
            this.pk_manag_id_ban = pk_manag_id_ban;
            this.manag_id_bancoag = manag_id_bancoag;
            this.manag_nombre_banco = manag_nombre_banco;
            this.manag_status = manag_status;
            this.manag_status_conciliacion = manag_status_conciliacion;
        }
    }


}
