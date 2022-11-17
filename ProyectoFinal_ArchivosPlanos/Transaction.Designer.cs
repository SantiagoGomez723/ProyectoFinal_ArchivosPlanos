
namespace ProyectoFinal_ArchivosPlanos
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoadData = new System.Windows.Forms.DataGridView();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.btnExportDB = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.IDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoadData
            // 
            this.dgvLoadData.AllowUserToAddRows = false;
            this.dgvLoadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoadData.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoadData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoadData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoadData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoadData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDGV,
            this.NameDGV,
            this.LastNameDGV,
            this.PhoneDGV,
            this.EmailDGV,
            this.DateDGV});
            this.dgvLoadData.EnableHeadersVisualStyles = false;
            this.dgvLoadData.GridColor = System.Drawing.Color.White;
            this.dgvLoadData.Location = new System.Drawing.Point(12, 81);
            this.dgvLoadData.Name = "dgvLoadData";
            this.dgvLoadData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoadData.Size = new System.Drawing.Size(759, 277);
            this.dgvLoadData.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Blue;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignOut.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(808, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(92, 23);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Cerrar sesión";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Blue;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImport.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(808, 81);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(92, 46);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Importar archivo csv/txt";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.BackColor = System.Drawing.Color.Blue;
            this.btnAddRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddRegister.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRegister.ForeColor = System.Drawing.Color.White;
            this.btnAddRegister.Location = new System.Drawing.Point(808, 164);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(92, 46);
            this.btnAddRegister.TabIndex = 3;
            this.btnAddRegister.Text = "Agregar nuevo registro";
            this.btnAddRegister.UseVisualStyleBackColor = false;
            this.btnAddRegister.Click += new System.EventHandler(this.btnAddRegister_Click);
            // 
            // btnExportDB
            // 
            this.btnExportDB.BackColor = System.Drawing.Color.Blue;
            this.btnExportDB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportDB.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDB.ForeColor = System.Drawing.Color.White;
            this.btnExportDB.Location = new System.Drawing.Point(808, 312);
            this.btnExportDB.Name = "btnExportDB";
            this.btnExportDB.Size = new System.Drawing.Size(92, 46);
            this.btnExportDB.TabIndex = 4;
            this.btnExportDB.Text = "Exportar a la base de datos";
            this.btnExportDB.UseVisualStyleBackColor = false;
            this.btnExportDB.Click += new System.EventHandler(this.btnExportDB_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.White;
            this.lblDatos.Location = new System.Drawing.Point(275, 39);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(189, 25);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Manipulación de datos";
            // 
            // IDDGV
            // 
            this.IDDGV.HeaderText = "Identificacion";
            this.IDDGV.Name = "IDDGV";
            // 
            // NameDGV
            // 
            this.NameDGV.HeaderText = "Nombre(s)";
            this.NameDGV.Name = "NameDGV";
            // 
            // LastNameDGV
            // 
            this.LastNameDGV.HeaderText = "Apellido(s)";
            this.LastNameDGV.Name = "LastNameDGV";
            // 
            // PhoneDGV
            // 
            this.PhoneDGV.HeaderText = "Telefono";
            this.PhoneDGV.Name = "PhoneDGV";
            // 
            // EmailDGV
            // 
            this.EmailDGV.HeaderText = "Correo electrónico";
            this.EmailDGV.Name = "EmailDGV";
            // 
            // DateDGV
            // 
            this.DateDGV.HeaderText = "Fecha de nacimiento";
            this.DateDGV.Name = "DateDGV";
            // 
            // btnDeleteRegister
            // 
            this.btnDeleteRegister.BackColor = System.Drawing.Color.Blue;
            this.btnDeleteRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteRegister.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRegister.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRegister.Location = new System.Drawing.Point(808, 238);
            this.btnDeleteRegister.Name = "btnDeleteRegister";
            this.btnDeleteRegister.Size = new System.Drawing.Size(92, 46);
            this.btnDeleteRegister.TabIndex = 6;
            this.btnDeleteRegister.Text = "Eliminar registro";
            this.btnDeleteRegister.UseVisualStyleBackColor = false;
            this.btnDeleteRegister.Click += new System.EventHandler(this.btnDeleteRegister_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 408);
            this.Controls.Add(this.btnDeleteRegister);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnExportDB);
            this.Controls.Add(this.btnAddRegister);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.dgvLoadData);
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadData;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddRegister;
        private System.Windows.Forms.Button btnExportDB;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDGV;
        private System.Windows.Forms.Button btnDeleteRegister;
    }
}