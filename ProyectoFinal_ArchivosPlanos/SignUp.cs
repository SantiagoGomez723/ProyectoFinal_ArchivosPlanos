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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        //Agregamos la clase Connection
        Connection connect = new Connection();

        //Creamos métodos para validar campos en los TextBox
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo teclas numéricas
            if ((e.KeyChar >= 48 && e.KeyChar <= 59) || e.KeyChar == 13 || e.KeyChar == 08)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            // Solo 10 caracteres
            if (txtID.TextLength == 10)
            {
                if (e.KeyChar == 13 || e.KeyChar == 08)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Alerta cuando no se ingresan letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Alerta cuando no se ingresan letras
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtConPassd_TextChanged(object sender, EventArgs e)
        {
            //Verifica que se las contraseñas coincidan 
            if (txtConPassd.Text == txtPassword.Text)
            {
                lblConfirm.ForeColor = Color.White;
                lblConfirm.Text = "Si Coinciden";
            }
            else
            {
                lblConfirm.ForeColor = Color.Red;
                lblConfirm.Text = "No coincide";
            }
        }
        //Validar que no hayan campos vacíos
        private void txtName_Validated(object sender, EventArgs e)
        {

            if (txtName.Text.Trim() == "")
            {
                epVali.SetError(txtName, "Campo Vacio");
                txtName.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }
        //Validar que no hayan campos vacíos
        private void txtLastName_Validated(object sender, EventArgs e)
        {
            if (txtLastName.Text.Trim() == "")
            {
                epVali.SetError(txtLastName, "Campo Vacio");
                txtLastName.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }
        //Validar que no hayan campos vacíos
        private void txtUser_Validated(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                epVali.SetError(txtUser, "Campo Vacio");
                txtUser.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }
        //Validar que no hayan campos vacíos
        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                epVali.SetError(txtEmail, "Campo Vacio");
                txtEmail.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }
        //Validar que no hayan campos vacíos
        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                epVali.SetError(txtPassword, "Campo Vacio");
                txtPassword.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }
        //Validar que no hayan campos vacíos
        private void txtConPassd_Validated(object sender, EventArgs e)
        {
            if (txtConPassd.Text.Trim() == "")
            {
                epVali.SetError(txtConPassd, "Campo Vacio");
                txtConPassd.Focus();
            }
            else
            {
                epVali.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string name = txtName.Text;
            string Lname = txtLastName.Text;
            string email = txtEmail.Text;
            string user = txtUser.Text;
            string password = txtConPassd.Text;

            //Valida que el correo cuente con la sintaxis correspondente de ser asi envia los datos a la bd
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                MessageBox.Show("Ingrese una dirección de email valida");
            }
            else
            {
                connect.Register(int.Parse(ID), name, Lname, email, user, password);
                connect.Clear(this);
                MessageBox.Show("El usuario se ha registrado correctamente");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
