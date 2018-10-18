using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace InicioSesion
{
    public partial class InicioSesionForm : Form
    {
        public InicioSesionForm()
        {
            InitializeComponent();            
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string username = Txt_loginUser.Text;
            string password = Txt_loginPass.Text;
            Logica capaLogica = new Logica();

            if (username == "" || password == "")
            {
                MessageBox.Show("Los campos son obligatorios");
            }


            if (capaLogica.login(username, password))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void InicioSesionForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string startupPath = Environment.CurrentDirectory;
            Help.ShowHelp(this, startupPath+ "/ayuda_inicio_sesion/Ayuda_seguridad.chm", "ayuda.html#ayuda");
        }
    }
}
