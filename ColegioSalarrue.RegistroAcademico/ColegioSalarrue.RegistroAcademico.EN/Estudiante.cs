using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioSalarrue.RegistroAcademico.EN
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int NIE { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set;}
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public int IdGrado { get; set; }
        public Estudiante() { }
        public Estudiante(int pId, string pNombres, string pApellidos, int pNIE, DateTime pFechaNacimiento, string pGenero, string pDireccion, string pMunicipio, string pDepartamento, string pTelefono, int pIdGrado)
        {
            Id = pId;
            Nombres = pNombres;
            Apellidos = pApellidos;
            NIE = pNIE;
            FechaNacimiento = pFechaNacimiento;
            Genero = pGenero;
            Direccion = pDireccion;
            Municipio = pMunicipio;
            Departamento = pDepartamento;
            Telefono = pTelefono;
            IdGrado = pIdGrado;
        }
    }
}
