using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal_ArchivosPlanos
{
    class Connection
    {
        //Declaración de variables a utilizar para conexión y consultas
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Connection()
        {
            //Asignamos la conexión en el constructor
            try
            {
                string host = @".";
                string database = "ArchivosPlanos";

                con = new SqlConnection($"Data Source={host}; Initial Catalog={database}; Integrated Security=True");
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecto(s). Verifique los datos.");
            }
        }
        //Creamos un método que retorna un booleano para acceder al sistema
        public bool login(string user, string password)
        {
            bool access = false;
            try
            {
                string query = $"Select strPassword from tbl_Usuario where strUsuario = '{user}'";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.GetString(0) == password)
                {
                    access = true;
                }
                else
                {
                    access = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al iniciar sesión");
            }

            dr.Close();
            return access;
        }

        //Este método es para registrar el usuario
        public void Register(int identificacion, string nombre, string apellido, string correo, string usuario, string password)
        {
            try
            {
                string query = $"Insert into tbl_Usuario (IDUser, strNombre, strApellido, strCorreo, strUsuario, strPassword) values ({identificacion}, '{nombre}', '{apellido}', '{correo}', '{usuario}', '{password}')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al registrarse");
            }
        }
        //Este método es para exportar los datos hacia la base de datos
        public void ExportData(string ID, string Name, string LName, string Phone, string Email, string Date)
        {
            try
            {
                string query = $"Insert into tbl_Registro (strIdentificacion, strNombre, strApellido, strTelefono, strCorreo, datFechaNacimiento)  values ('{ID}', '{Name}','{LName}','{Phone}','{Email}','{Date}')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No se agregaron algunos datos");
            }
        }
        //Método para limpiar los campos
        public void Clear(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Items.Clear();
                    ((ComboBox)txt).Text = "";
                }
            }
        }
        //método para cerrar el formulario
        public void Close()
        {
            con.Close();
        }

    }
}
