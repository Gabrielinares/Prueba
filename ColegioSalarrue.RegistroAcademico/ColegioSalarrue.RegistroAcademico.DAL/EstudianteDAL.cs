using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioSalarrue.RegistroAcademico.DAL;
using ColegioSalarrue.RegistroAcademico.EN;

namespace ColegioSalarrue.RegistroAcademico.DAL
{
    public class EstudianteDAL
    {
        public static int AgregarEstudiante(Estudiante pEstudiante)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarEstudiante", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pEstudiante.Id);
                    _command.Parameters.AddWithValue("@Nombres", pEstudiante.Nombres);
                    _command.Parameters.AddWithValue("@Apellidos", pEstudiante.Apellidos);
                    _command.Parameters.AddWithValue("@NIE", pEstudiante.NIE);
                    _command.Parameters.AddWithValue("@FechaNacimiento", pEstudiante.FechaNacimiento);
                    _command.Parameters.AddWithValue("@Genero", pEstudiante.Genero);
                    _command.Parameters.AddWithValue("@Direccion", pEstudiante.Direccion);
                    _command.Parameters.AddWithValue("@Municipio", pEstudiante.Municipio);
                    _command.Parameters.AddWithValue("@Departamento", pEstudiante.Departamento);
                    _command.Parameters.AddWithValue("@Telefono", pEstudiante.Telefono);
                    _command.Parameters.AddWithValue("@IdGrado", pEstudiante.IdGrado);

                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }

            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

        //Aca haras modificar

        public static int ModificarEstudiante(Estudiante pEstudiante)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarEstudiante", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombres", pEstudiante.Nombres);
                    _command.Parameters.AddWithValue("@Apellidos", pEstudiante.Apellidos);
                    _command.Parameters.AddWithValue("@NIE", pEstudiante.NIE);
                    _command.Parameters.AddWithValue("@FechaNacimiento", pEstudiante.FechaNacimiento);
                    _command.Parameters.AddWithValue("@Genero", pEstudiante.Genero);
                    _command.Parameters.AddWithValue("@Direccion", pEstudiante.Direccion);
                    _command.Parameters.AddWithValue("@Municipio", pEstudiante.Municipio);
                    _command.Parameters.AddWithValue("@Departamento", pEstudiante.Departamento);
                    _command.Parameters.AddWithValue("@Telefono", pEstudiante.Telefono);
                    _command.Parameters.AddWithValue("@IdGrado", pEstudiante.IdGrado);

                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }

            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

        //Aca eliminar

        public static int EliminarEstudiante(int pId)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarEstudiante", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);

                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }

            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

        //Buscar

        public static List<Estudiante> BuscarEstudiantePorNIE(Int32 pNIE)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarEstudiante", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombres", pNIE);

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Estudiante> _listaEstudiante = new List<Estudiante>();

                    while (_reader.Read())
                    {
                        Estudiante _estudiante = new Estudiante();

                        _estudiante.Id = _reader.GetInt32(0);
                        _estudiante.Nombres = _reader.GetString(1);
                        _estudiante.Apellidos = _reader.GetString(2);
                        _estudiante.NIE = _reader.GetInt32(3);
                        _estudiante.FechaNacimiento = _reader.GetDateTime(4);
                        _estudiante.Genero = _reader.GetString(5);
                        _estudiante.Direccion = _reader.GetString(6);
                        _estudiante.Municipio = _reader.GetString(7);
                        _estudiante.Departamento = _reader.GetString(8);
                        _estudiante.Telefono = _reader.GetString(9);
                        _estudiante.IdGrado = _reader.GetInt32(10);

                        _listaEstudiante.Add(_estudiante);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaEstudiante;
                }
            }

            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }

        }

        //Obtener

        public static List<Estudiante> ObtenerEstudiante()
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("MostrarEstudiantes", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Estudiante> _listaEstudiantes = new List<Estudiante>();

                    while (_reader.Read())
                    {
                        Estudiante _estudiante = new Estudiante();

                        _estudiante.Id = _reader.GetInt32(0);
                        _estudiante.Nombres = _reader.GetString(1);
                        _estudiante.Apellidos = _reader.GetString(2);
                        _estudiante.NIE = _reader.GetInt32(3);
                        _estudiante.FechaNacimiento = _reader.GetDateTime(4);
                        _estudiante.Genero = _reader.GetString(5);
                        _estudiante.Direccion = _reader.GetString(6);
                        _estudiante.Municipio = _reader.GetString(7);
                        _estudiante.Departamento = _reader.GetString(8);
                        _estudiante.Telefono = _reader.GetString(9);
                        _estudiante.IdGrado = _reader.GetInt32(10);

                        _listaEstudiantes.Add(_estudiante);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaEstudiantes;
                }
            }

            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }

        }
    }
}

