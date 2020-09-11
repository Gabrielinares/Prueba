using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public float Total { get; set; }

        public int EmpleadoId { get; set; }

        public int ClienteId { get; set; }

        public Venta () { } //Constructor vacio

        public Venta (int pId, DateTime pFecha, float pTotal, int pEmpleadoId, int pCLienteId)
        {
            Id = pId;
            Fecha = pFecha;
            Total = pTotal;
            EmpleadoId = pEmpleadoId;
            ClienteId = pCLienteId;
        }

    }
}
