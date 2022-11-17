using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal_ArchivosPlanos
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        //Declaramos un stream para manejar los archivos de texto y declaramos la clase connection
        private Stream Stream;
        Connection connect = new Connection();
        //Importar datos de un csv/txt al presionar el botón
        private void btnImport_Click(object sender, EventArgs e)
        {
            string line;

            OpenFileDialog ArchiveImport = new OpenFileDialog();
            ArchiveImport.InitialDirectory = @"c:\";
            ArchiveImport.Filter = "Archivos CSV|*.csv|Archivos TXT|*.txt";
            ArchiveImport.RestoreDirectory = true;

            if (ArchiveImport.ShowDialog() == DialogResult.OK)
            {
                if ((Stream = ArchiveImport.OpenFile()) != null)
                {
                    using (Stream)
                    {
                        StreamReader file = new StreamReader(ArchiveImport.FileName);
                        while ((line = file.ReadLine()) != null)
                        {
                            //Almacena el contenido en un arreglo separándolo por medio de los ;
                            string[] columnas = line.Split(';');
                            dgvLoadData.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3], columnas[4], columnas[5]);
                        }
                        file.Close();
                    }
                }
            }
        }
        //Botón que agrega una fila al DataGridView
        private void btnAddRegister_Click(object sender, EventArgs e)
        {
            dgvLoadData.Rows.Add();
        }
        //Botón exportar los registros a la base de datos
        private void btnExportDB_Click(object sender, EventArgs e)
        {
            string ID, Name, lName, Phone, Email, Date;
            string[] BirthDay = new string[3];
            try
            {
                foreach (DataGridViewRow row in dgvLoadData.Rows)
                {
                    ID = Convert.ToString(row.Cells["IDDGV"].Value);
                    Name = Convert.ToString(row.Cells["NameDGV"].Value);
                    lName = Convert.ToString(row.Cells["LastNameDGV"].Value);
                    Phone = Convert.ToString(row.Cells["PhoneDGV"].Value);
                    Email = Convert.ToString(row.Cells["EmailDGV"].Value);
                    Date = Convert.ToString(row.Cells["DateDGV"].Value);

                    //Acomodamos la fecha para ser envidada en el formato correcto a la base de datos
                    BirthDay = Date.Split('/');                  
                    Date = $"{BirthDay[2]}-{BirthDay[1]}-{BirthDay[0]}";

                    //Método de exportación de la clase Connection
                    connect.ExportData(ID, Name, lName, Phone, Email, Date);
                }
                MessageBox.Show("Datos agregados");
                dgvLoadData.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar datos" + ex.ToString());
            }
        }
        //Botón para cerrar sesión
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //Cerramos sesión y volvemos a la pantalla del login
            connect.Close();
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnDeleteRegister_Click(object sender, EventArgs e)
        {
            dgvLoadData.Rows.Remove(dgvLoadData.CurrentRow);
        }
    }
}
