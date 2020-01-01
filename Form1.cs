using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlHorasProyectos
{
    public partial class Form1 : Form
    {
        private const string Format = "yyyy-MM-dd HH:mm:ss";
        BaseDeDatos datos = new BaseDeDatos();
        private bool cerrar = true;

        public Form1()
        {
            InitializeComponent();
            datos.Conectar();
            string[] select;
            select = datos.buscar_usuarios();
            ImgRelog.Visible = false;

            CbUsuario.Text = "::Elegír usuario";
            foreach (string value in select)
            {
                CbUsuario.Items.Add(value);
            }
        }

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            if(CbUsuario.SelectedItem != null)
            {

            
                string Usuario = CbUsuario.SelectedItem.ToString(); 
                int id_usuario;
                int insertUsuario;
                string TiempoTrabajado;

            
                id_usuario = datos.id_usuario(Usuario);
                insertUsuario = datos.validar_insert_horario(id_usuario);
                

                if (insertUsuario == 1)
                {

                    BtnEmpezar.BackColor = Color.Crimson;
                    BtnEmpezar.Text = "Finalizar";
                    CbUsuario.Enabled = false;
                    ImgRelog.Visible = true;
                    LblRespuesta.Text = "";
                    cerrar = false;
                }
                if (insertUsuario == 2)
                {
                    TiempoTrabajado = datos.TiempoTrabajado(id_usuario);
                    BtnEmpezar.BackColor = Color.SpringGreen;
                    BtnEmpezar.Text = "Empezar";
                    CbUsuario.Enabled = true;
                    ImgRelog.Visible = false;
                    LblRespuesta.Text = "Tiempo Trabajado: " +TiempoTrabajado;
                    cerrar = true;
                }                
            }
            else
            {
                LblRespuesta.Text = "Seleccione un Usuario.";
            }          

            
        }

        private void CbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("asdas");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar == false)
            {
                DialogResult pregunta = MessageBox.Show("CABEZÓN, si lo cerrás ahora vas a perder todo lo marcado desde que iniciaste la APP.","Cerrar",
                    MessageBoxButtons.OKCancel);
                if(pregunta == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
