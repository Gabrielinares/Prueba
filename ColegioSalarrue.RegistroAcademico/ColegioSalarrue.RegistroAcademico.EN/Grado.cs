using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioSalarrue.RegistroAcademico.EN
{
    public class Grado
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Seccion {get; set;}
        public string Abreviatura{ get; set; }

        public Grado() {}

        public Grado(int pId, string pNombre, string pSeccion, string pAbreviatura)
        {
            Id = pId;
            Nombre = pNombre;
            Seccion = pSeccion;
            Abreviatura = pAbreviatura;
        }




    }
}
