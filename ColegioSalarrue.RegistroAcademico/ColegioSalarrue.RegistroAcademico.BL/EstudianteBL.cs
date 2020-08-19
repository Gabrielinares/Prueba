using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ColegioSalarrue.RegistroAcademico.DAL;
using ColegioSalarrue.RegistroAcademico.EN;
using ColegioSalarrue.RegistroAcademico.BL;
namespace ColegioSalarrue.RegistroAcademico.BL
{
    public class EstudianteBL
    {
        public List<Estudiante> ObtenerEstudiante()
        {
            return EstudianteDAL.ObtenerEstudiante();
        }

        public int AgregarEstudiante(Estudiante pEstudiante)
        {
            return EstudianteDAL.AgregarEstudiante(pEstudiante);
        }

        public int ModificarEstudiante(Estudiante pEstudiante)
        {
            return EstudianteDAL.ModificarEstudiante(pEstudiante);
        }

        public int EliminarEstudiante(int pId)
        {
            return EstudianteDAL.EliminarEstudiante(pId);
        }

        public List<Estudiante> BuscarEstudiantePorNombres(int pNIE)
        {
            return EstudianteDAL.BuscarEstudiantePorNIE(pNIE);
        }


    }
}
                