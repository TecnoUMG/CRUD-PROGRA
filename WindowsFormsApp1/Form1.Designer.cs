namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Personajes = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Raza = new System.Windows.Forms.Label();
            this.Poder = new System.Windows.Forms.Label();
            this.NivelPoder = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Crear = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.History = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Personajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personajes
            // 
            this.Personajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personajes.Location = new System.Drawing.Point(12, 177);
            this.Personajes.Name = "Personajes";
            this.Personajes.Size = new System.Drawing.Size(589, 150);
            this.Personajes.TabIndex = 1;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(644, 245);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(109, 23);
            this.Cargar.TabIndex = 2;
            this.Cargar.Text = "Cargar Datos";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(24, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(24, 44);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre";
            // 
            // Raza
            // 
            this.Raza.AutoSize = true;
            this.Raza.Location = new System.Drawing.Point(24, 73);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(32, 13);
            this.Raza.TabIndex = 5;
            this.Raza.Text = "Raza";
            // 
            // Poder
            // 
            this.Poder.AutoSize = true;
            this.Poder.Location = new System.Drawing.Point(24, 103);
            this.Poder.Name = "Poder";
            this.Poder.Size = new System.Drawing.Size(35, 13);
            this.Poder.TabIndex = 6;
            this.Poder.Text = "Poder";
            // 
            // NivelPoder
            // 
            this.NivelPoder.Location = new System.Drawing.Point(78, 101);
            this.NivelPoder.Name = "NivelPoder";
            this.NivelPoder.Size = new System.Drawing.Size(120, 20);
            this.NivelPoder.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(27, 139);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 11;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(540, 36);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 20);
            this.DateTime.TabIndex = 12;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Location = new System.Drawing.Point(319, 115);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(42, 13);
            this.History.TabIndex = 13;
            this.History.Text = "Historia";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(367, 115);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(100, 20);
            this.HistoryBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.History);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NivelPoder);
            this.Controls.Add(this.Poder);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Personajes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Personajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Personajes;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Raza;
        private System.Windows.Forms.Label Poder;
        private System.Windows.Forms.NumericUpDown NivelPoder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.TextBox HistoryBox;
    }
}

