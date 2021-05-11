using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Veterinario2021
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server=127.0.0.1; Database=veterinario2021; Uid=root; Pwd=; Port=3306");
          
        }
        public Boolean inicioSesion(String _DNI, String _Contraseña)
        {
            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuarios WHERE DNI=@_DNI ", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    String passwordConHash = resultado.GetString("Contraseña");
                    if (BCrypt.Net.BCrypt.Verify(_Contraseña, passwordConHash))
                    {
                        conexion.Close();
                        //si entra aquí es porque sí que estan bien el usuario y la contraseña
                        return true;
                    }
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


        public Boolean insertaUsuarios(string _DNI, string _Nombre, string _Apellido, string _Contraseña, string _Email, string _Telefono, string _Localidad)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuarios(DNI,Nombre,Apellido,Contraseña,Email,Telefono,Localidad)  VALUES (@_DNI,@_Nombre,@_Apellido,@_Contraseña,@_Email,@_Telefono,@_Localidad )", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Apellido", _Apellido);
                consulta.Parameters.AddWithValue("@_Contraseña", _Contraseña);
                consulta.Parameters.AddWithValue("@_Email", _Email);
                consulta.Parameters.AddWithValue("@_Telefono", _Telefono);
                consulta.Parameters.AddWithValue("@_Localidad", _Localidad);

                int resultado = consulta.ExecuteNonQuery(); //guardo el insert
                
                if (resultado > 0 )
                {
                    conexion.Close();
                    //si entra aqui es porque si que esta bien el usuario y la contraseña
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        public Boolean insertaMascota(string _Chip, string _NombreMascota, string _Raza, string _Propietario)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO mascotas(Chip,NombreMascota,Raza,Propietario)  VALUES (@_Chip,@_NombreMascota,@_Raza,@_Propietario)", conexion);
                consulta.Parameters.AddWithValue("@_Chip", _Chip);
                consulta.Parameters.AddWithValue("@_NombreMascota", _NombreMascota);
                consulta.Parameters.AddWithValue("@_Raza", _Raza);
                consulta.Parameters.AddWithValue("@_Propietario", _Propietario);
               

                int resultado = consulta.ExecuteNonQuery(); //guardo el insert
             
                if ( resultado > 0)
                {
                    conexion.Close();
                    //si entra aqui es porque si que esta bien el usuario y la contraseña
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        public Boolean insertaCita(string _DNI, string _Telefono, string _Chip, string _ProblemaMascota, string _Calendario)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO mascotas(DNI,Telefono,Chip,ProblemaMascota,Calendario)  VALUES (@_DNI,@_Telefono,@_Chip,@_ProblemaMascota,@Calendario)", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Telefono", _Telefono);
                consulta.Parameters.AddWithValue("@_Chip", _Chip);
                consulta.Parameters.AddWithValue("@_ProblemaMascota", _ProblemaMascota);
                consulta.Parameters.AddWithValue("@Calendario", _Calendario);


                int resultado = consulta.ExecuteNonQuery(); //guardo el insert

                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aqui es porque si que esta bien el usuario y la contraseña
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


    }
}
