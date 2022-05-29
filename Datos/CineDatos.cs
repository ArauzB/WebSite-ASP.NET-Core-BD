using CRUDCORE.Models;
using System.Data.SqlClient;
using System.Data;

namespace CRUDCORE.Datos
{
    public class CineDatos
    {

        public List<CineModel> Listar() { 
        
            var oLista = new List<CineModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL())) { 
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Consultar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader()) { 

                    while (dr.Read()) {
                        oLista.Add(new CineModel() {
                            ID = Convert.ToInt32(dr["ID"]),
                            Titulo = dr["Titulo"].ToString(),
                            Comentario = dr["Comentario"].ToString(),
                            Imagen= dr["Imagen"].ToString(),
                            Fecha= dr["Fecha"].ToString(),
                            Director= dr["Director"].ToString(),
                            Guion= dr["Guion"].ToString(),
                            Sinopsis= dr["Sinopsis"].ToString(),
                            Trailer= dr["Trailer"].ToString(),
                            Categoria= dr["Categoria"].ToString()
                        });

                    }
                }
            }

            return oLista;
        }


            public List<CineModel> ListarPelicula() { 
        
            var oLista = new List<CineModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL())) { 
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ConsultarPelicula", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader()) { 

                    while (dr.Read()) {
                        oLista.Add(new CineModel() {
                            ID = Convert.ToInt32(dr["ID"]),
                            Titulo = dr["Titulo"].ToString(),
                            Comentario = dr["Comentario"].ToString(),
                            Imagen= dr["Imagen"].ToString(),
                            Fecha= dr["Fecha"].ToString(),
                            Director= dr["Director"].ToString(),
                            Guion= dr["Guion"].ToString(),
                            Sinopsis= dr["Sinopsis"].ToString(),
                            Trailer= dr["Trailer"].ToString(),
                            Categoria= dr["Categoria"].ToString()
                        });

                    }
                }
            }

            return oLista;
        }


        public List<CineModel> ListarSerie() { 
        
            var oLista = new List<CineModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL())) { 
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ConsultarSerie", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader()) { 

                    while (dr.Read()) {
                        oLista.Add(new CineModel() {
                            ID = Convert.ToInt32(dr["ID"]),
                            Titulo = dr["Titulo"].ToString(),
                            Comentario = dr["Comentario"].ToString(),
                            Imagen= dr["Imagen"].ToString(),
                            Fecha= dr["Fecha"].ToString(),
                            Director= dr["Director"].ToString(),
                            Guion= dr["Guion"].ToString(),
                            Sinopsis= dr["Sinopsis"].ToString(),
                            Trailer= dr["Trailer"].ToString(),
                            Categoria= dr["Categoria"].ToString()
                        });

                    }
                }
            }

            return oLista;
        }




        public List<CineModel> ListarJuego() { 
        
            var oLista = new List<CineModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL())) { 
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ConsultarJuego", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader()) { 

                    while (dr.Read()) {
                        oLista.Add(new CineModel() {
                            ID = Convert.ToInt32(dr["ID"]),
                            Titulo = dr["Titulo"].ToString(),
                            Comentario = dr["Comentario"].ToString(),
                            Imagen= dr["Imagen"].ToString(),
                            Fecha= dr["Fecha"].ToString(),
                            Director= dr["Director"].ToString(),
                            Guion= dr["Guion"].ToString(),
                            Sinopsis= dr["Sinopsis"].ToString(),
                            Trailer= dr["Trailer"].ToString(),
                            Categoria= dr["Categoria"].ToString()
                        });

                    }
                }
            }

            return oLista;
        }







        public CineModel Obtener(int ID)
        {

            var oContacto = new CineModel();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerID", conexion);
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                            oContacto.ID = Convert.ToInt32(dr["ID"]);
                            oContacto.Titulo = dr["Titulo"].ToString();
                            oContacto.Comentario = dr["Comentario"].ToString();
                            oContacto.Imagen= dr["Imagen"].ToString();
                            oContacto.Fecha= dr["Fecha"].ToString();
                            oContacto.Director= dr["Director"].ToString();
                            oContacto.Guion= dr["Guion"].ToString();
                            oContacto.Sinopsis= dr["Sinopsis"].ToString();
                            oContacto.Trailer= dr["Trailer"].ToString();
                            oContacto.Categoria= dr["Categoria"].ToString();
                    }
                }
            }

            return oContacto;
        }



            public bool Guardar(CineModel ocontacto) {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_GuardarDB", conexion);
                    cmd.Parameters.AddWithValue("Titulo", ocontacto.Titulo);
                    cmd.Parameters.AddWithValue("Comentario", ocontacto.Comentario);
                    cmd.Parameters.AddWithValue("Imagen", ocontacto.Imagen);
                    cmd.Parameters.AddWithValue("Fecha", ocontacto.Fecha);
                    cmd.Parameters.AddWithValue("Director", ocontacto.Director);
                    cmd.Parameters.AddWithValue("Guion", ocontacto.Guion);
                    cmd.Parameters.AddWithValue("Sinopsis", ocontacto.Sinopsis);
                    cmd.Parameters.AddWithValue("Trailer", ocontacto.Trailer);
                    cmd.Parameters.AddWithValue("Categoria", ocontacto.Categoria);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e) {

                string error = e.Message;
                rpta = false;
            }



            return rpta;
        }




        public bool Editar(CineModel ocontacto)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_EditarBD", conexion);
                    cmd.Parameters.AddWithValue("ID", ocontacto.ID);
                    cmd.Parameters.AddWithValue("Titulo", ocontacto.Titulo);
                    cmd.Parameters.AddWithValue("Comentario", ocontacto.Comentario);
                    cmd.Parameters.AddWithValue("Imagen", ocontacto.Imagen);
                    cmd.Parameters.AddWithValue("Fecha", ocontacto.Fecha);
                    cmd.Parameters.AddWithValue("Director", ocontacto.Director);
                    cmd.Parameters.AddWithValue("Guion", ocontacto.Guion);
                    cmd.Parameters.AddWithValue("Sinopsis", ocontacto.Sinopsis);
                    cmd.Parameters.AddWithValue("Trailer", ocontacto.Trailer);
                    cmd.Parameters.AddWithValue("Categoria", ocontacto.Categoria);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e)
            {

                string error = e.Message;
                rpta = false;
            }
            return rpta;
        }





        public bool Eliminar(int ID)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_EliminarBD", conexion);
                    cmd.Parameters.AddWithValue("ID", ID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;


            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }
            return rpta;
        }









        }


    }

