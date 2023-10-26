﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloHoteleria;
using System.Drawing;
using System.Windows.Forms;

namespace ControladorHoteleria
{
    public class Controlador
    {
        public Sentencias sn;

        private List<TipoHabitacion> habs;
        private List<Habitacion> habitaciones;
        public Controlador()
        {
            this.sn = new Sentencias();
            this.habs = this.sn.getTiposHabitacion();
            this.habitaciones =  this.sn.getHabitaciones();
        }

        public List<string> getTypes()
        {
            List<string> types = new List<string>();
            foreach(TipoHabitacion th in habs)
            {
                types.Add(th.thab_nombre);
            }
            return types;
        }

        public void fillHabitaciones(ComboBox cmb, string selected)
        {
            int id_seleccionado = 0;
            foreach(TipoHabitacion th in habs) {
                if  (th.thab_nombre.Equals(selected))
                {
                   id_seleccionado = th.thab_id; 
                }  
            }

            foreach(Habitacion _h in habitaciones)
            {
                if(_h.tipo == id_seleccionado)
                {
                    cmb.Items.Add(_h.numero.ToString());
                }
            }
        }
    }

}
