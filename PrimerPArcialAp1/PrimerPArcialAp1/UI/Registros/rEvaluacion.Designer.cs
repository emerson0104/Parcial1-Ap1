namespace PrimerPArcialAp1.UI.Registros
{
    partial class rEvaluacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEvaluacion));
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PerdidoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LogradoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(66, 35);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.IdNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // FechaDateTimePicker1
            // 
            this.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker1.Location = new System.Drawing.Point(264, 31);
            this.FechaDateTimePicker1.Name = "FechaDateTimePicker1";
            this.FechaDateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.FechaDateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estudiante";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(66, 68);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.EstudianteTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PerdidoTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LogradoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ValorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificacion Tarea Parcial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Perdido";
            // 
            // PerdidoTextBox
            // 
            this.PerdidoTextBox.Location = new System.Drawing.Point(234, 36);
            this.PerdidoTextBox.Name = "PerdidoTextBox";
            this.PerdidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.PerdidoTextBox.TabIndex = 13;
            this.PerdidoTextBox.TextChanged += new System.EventHandler(this.PerdidoTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logrado";
            // 
            // LogradoTextBox
            // 
            this.LogradoTextBox.Location = new System.Drawing.Point(119, 36);
            this.LogradoTextBox.Name = "LogradoTextBox";
            this.LogradoTextBox.Size = new System.Drawing.Size(84, 20);
            this.LogradoTextBox.TabIndex = 11;
            this.LogradoTextBox.TextChanged += new System.EventHandler(this.LogradoTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(13, 36);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(80, 20);
            this.ValorTextBox.TabIndex = 9;
            this.ValorTextBox.TextChanged += new System.EventHandler(this.ValorTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(2, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 77);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Como vas Deberias";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.comboBox1.Location = new System.Drawing.Point(70, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pronostico";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(13, 280);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(98, 31);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(117, 280);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 31);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(216, 280);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(114, 31);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(121, 35);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 23);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 344);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EstudianteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rEvaluacion";
            this.Text = "rEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PerdidoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LogradoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BuscarButton;
    }
}