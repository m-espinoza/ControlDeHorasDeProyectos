using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;



namespace ControlHorasProyectos
{
    class BaseDeDatos
    {
        MySqlConnection con; //Conexion
        MySqlCommand cmd; //Comandos
        MySqlDataReader dr; //Mostrar
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        //Valor para saber que es de la misma secion.
        private Int32 SessionUnix = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

        //Archivo Settings.settings
        private string CadenaConexion = "server=" + Properties.Settings.Default.Server + ";" +
            "Database=" + Properties.Settings.Default.nombredb + ";" +
            "Uid=" + Properties.Settings.Default.Uid + ";" +
            "Pwd=" + Properties.Settings.Default.Pwd + ";";

        private string[] respuesta;

        public void Conectar()
        {           

            try
            {
                con = new MySqlConnection(CadenaConexion);
                con.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado" + ex.ToString());
            }

        }

        public string[] buscar_usuarios()
        {
            
            //Conectar();

            con = new MySqlConnection(CadenaConexion);
            try
            {
                //query
                string selectQuery = "select * from usuarios where id_estado=1";
                cmd = new MySqlCommand(selectQuery, con);         
                
                //uso dataadapter y dataset para contar la cantidad de filas
                da = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "table1");
                int cantidad = ds.Tables["table1"].Rows.Count;

                //genero el array
                string[] respuesta = new string[cantidad];

                con.Open();
                dr = cmd.ExecuteReader();
                
                int i=0;
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //MessageBox.Show();
                        //i = Convert.ToInt32(usuarios.GetValue(0));
                        respuesta[i] = dr.GetValue(1).ToString();
                        i++;
                    }
                }
                
                dr.Close();
                return respuesta;
                
            }
            catch (Exception)
            {
                return respuesta;
            }
        }

        public int id_usuario(string usuario)
        {
            int id_usuario = -1;
            string selectQuery;
                     

            con = new MySqlConnection(CadenaConexion);
            try
            {
                selectQuery = "SELECT id_usuario FROM usuarios WHERE usuario ='" + usuario + "'";
                cmd = new MySqlCommand(selectQuery, con);
                con.Open();
                dr = cmd.ExecuteReader();
                

                //Si trae algun resultado
                if (dr.HasRows)
                {
                    dr.Read();
                    id_usuario = dr.GetInt32(0);
                    con.Close();

                }

                //return validar_insert_horario(id_usuario);
                return id_usuario;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int validar_insert_horario(int id_usuario)
        {
            int insert;
            string proximo_estado;
            int estado;
            


            string insertHorario;

            if (id_usuario > 0)
            {


                proximo_estado = @"
                SELECT
	                IF( (
		                select id_estado
	                FROM
		                horarios
	                WHERE
		                1
		                and id_horario in ((
			                select
				                max(id_horario)
			                from
				                horarios
			                where id_usuario = @id_usuario
			                and horario_session = @SessionUnix )) ) = 1,
	                2,
	                1) as 'ProximoEstado'";             



                

                try
                {
                    con = new MySqlConnection(CadenaConexion);
                    cmd = new MySqlCommand(proximo_estado, con);

                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@SessionUnix", SessionUnix);
                    con.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        estado = dr.GetInt32(0);
                        con.Close();


                        con = new MySqlConnection(CadenaConexion);
                        insertHorario = $"INSERT INTO horarios VALUES(NULL,{id_usuario},CURRENT_TIMESTAMP,{SessionUnix},{estado})";
                        cmd = new MySqlCommand(insertHorario, con);
                        con.Open();
                        insert = cmd.ExecuteNonQuery();
                        con.Close();

                        return estado;

                    }
                    else
                    {
                        return 0;
                    }

                }
                catch (Exception)
                {
                    return 0;
                }

                
                
            }
            else
            {
                return 0;
            }
            
        }

        public string TiempoTrabajado(int id_usuario)
        {
            string Q_Tiempo_trabajado;
            string TiempoTrabajado;
            var DateDefault = new DateTime(1989, 12, 19, 15, 0, 0);
            //string insertHorario;
            //int insert;

            Q_Tiempo_trabajado = @"
                SELECT 
	                TIMEDIFF(
		                from_unixtime(
			                SUM( 
				                case
					                #Cuando el estado es 1, lo coloco en negativo para sumarcelo al del estado 2
					                when id_estado = 1 then unix_timestamp(horario_entrada) * -1
					                else unix_timestamp(horario_entrada)
				                end
			                ) #El resultado de la suma Lo paso a date 
		                ),'1969-12-31 21:00:00' #Se lo resto al origen del tiempo de unix
	                ) as 'TiempoTrabajado' 
                FROM
	                horarios
                WHERE
	                1
	                and id_usuario = @id_usuario
                    #Elijo el maximo numero de session para que me traiga la cuenta de tiempo de la session 
	                and horario_session = (
		                select MAX(horario_session) 
		                from horarios 
		                where id_usuario = @id_usuario
	                ) 	
                GROUP BY horario_session
	            ";


            try
            {
                con = new MySqlConnection(CadenaConexion);
                cmd = new MySqlCommand(Q_Tiempo_trabajado, con);

                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    TiempoTrabajado = dr.GetString(0).ToString();
                    con.Close();                    

                    return TiempoTrabajado;

                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {                
                return "";
            }



        }

    }

    
}
