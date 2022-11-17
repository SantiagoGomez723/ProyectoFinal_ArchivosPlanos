using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ArchivosPlanos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Instanciamos la clase conexión para utilizar sus métodos de forma global y el formulario para su posterior llamado
        Connection connect = new Connection();
        Transaction main = new Transaction();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = txtPassd.Text;

            bool access = connect.login(user, password);

            if (access)
            {
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecto(s). Verifique los datos.");
            }
        }
        //Método para llamar al formulario de registro cuando sea necesario
        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            SignUp registrar = new SignUp();
            registrar.Show();
        }
        //Método para cerrar aplicación
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
