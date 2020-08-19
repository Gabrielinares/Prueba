using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ColegioSalarrue.RegistroAcademico.DAL;
using ColegioSalarrue.RegistroAcademico.EN;

namespace ColegioSalarrue.RegistroAcademico.BL
{
    public class GradoBL
    {
        public List<Grado> ObtenerGrado()
        {
            return GradoDAL.ObtenerGrado();
        }

        public int AgregarGrado(Grado pGrado)
        {
            return GradoDAL.AgregarGrado(pGrado);
        }

        public int ModificarGrado(Grado pGrado)
        {
            return GradoDAL.ModificarGrado(pGrado);
        }

        public int EliminarGrado(int pId)
        {
            return GradoDAL.EliminarGrado(pId);
        }

        public List<Grado> BuscarGrado(int pId)
        {
            return GradoDAL.BuscarGrado(pId);
        }
    }
}
