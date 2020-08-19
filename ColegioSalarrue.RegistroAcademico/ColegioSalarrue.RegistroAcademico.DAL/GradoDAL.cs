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
    public class GradoDAL
    {
        public static int AgregarGrado(Grado pGrado)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarGrado", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pGrado.Id);
                    _command.Parameters.AddWithValue("@Nombre", pGrado.Nombre);
                    _command.Parameters.AddWithValue("@Seccion", pGrado.Seccion);
                    _command.Parameters.AddWithValue("@Abreviatura", pGrado.Abreviatura);

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



        ///Modificar

        public static int ModificarGrado(Grado pGrado)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarGrado", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pGrado.Id);
                    _command.Parameters.AddWithValue("@Nombre", pGrado.Nombre);
                    _command.Parameters.AddWithValue("@Seccion", pGrado.Seccion);
                    _command.Parameters.AddWithValue("@Abreviatura", pGrado.Abreviatura);

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


        //Eliminar

        public static int EliminarGrado(Int32 pId)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarGrado", _connection as SqlConnection);
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

        public static List<Grado> BuscarGrado(Int32 pId)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarGrado", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Grado> _listaGrado = new List<Grado>();

                    while (_reader.Read())
                    {
                        Grado _grado = new Grado();

                        _grado.Id = _reader.GetInt32(0);
                        _grado.Nombre = _reader.GetString(1);
                        _grado.Seccion = _reader.GetString(2);
                        _grado.Abreviatura = _reader.GetString(3);

                        _listaGrado.Add(_grado);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaGrado;
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

        public static List<Grado> ObtenerGrado()
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerGrado", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Grado> _listaGrado = new List<Grado>();

                    while (_reader.Read())
                    {
                        Grado _grado = new Grado();

                        _grado.Id = _reader.GetInt32(0);
                        _grado.Nombre = _reader.GetString(1);
                        _grado.Seccion = _reader.GetString(2);
                        _grado.Abreviatura = _reader.GetString(3);

                        _listaGrado.Add(_grado);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaGrado;
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