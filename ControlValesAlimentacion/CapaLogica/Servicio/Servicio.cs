using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio
{
    class Servicio
    {
        string nombre { get; set; }
        string nombrePerfil { get; set; }
        int valorServicio { get; set; }
        DateTime horaInicio { get; set; }
        DateTime horaFin { get; set; }

        public Servicio(string nombre,string nombrePerfil,int valorServicio,DateTime horaInicio,DateTime horaFin) {
            this.nombre = nombre;
            this.nombrePerfil = nombrePerfil;
            this.valorServicio = valorServicio;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

    }
}
