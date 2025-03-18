namespace MultApps.Windows
{
    partial class FrmCalculoAposentadoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtAnoscontribucão = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbldatanascimento = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblAnosContribucao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblAnosContribucao);
            this.panel1.Controls.Add(this.lblsexo);
            this.panel1.Controls.Add(this.lbldatanascimento);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtAnoscontribucão);
            this.panel1.Controls.Add(this.cmbSexo);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(32, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 415);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(19, 108);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 1;
            // 
            // txtAnoscontribucão
            // 
            this.txtAnoscontribucão.Location = new System.Drawing.Point(19, 167);
            this.txtAnoscontribucão.Name = "txtAnoscontribucão";
            this.txtAnoscontribucão.Size = new System.Drawing.Size(133, 20);
            this.txtAnoscontribucão.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(19, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 31);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // lbldatanascimento
            // 
            this.lbldatanascimento.AutoSize = true;
            this.lbldatanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatanascimento.Location = new System.Drawing.Point(15, 26);
            this.lbldatanascimento.Name = "lbldatanascimento";
            this.lbldatanascimento.Size = new System.Drawing.Size(130, 16);
            this.lbldatanascimento.TabIndex = 4;
            this.lbldatanascimento.Text = "Data de Nascimento";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(21, 85);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(38, 16);
            this.lblsexo.TabIndex = 5;
            this.lblsexo.Text = "Sexo";
            // 
            // lblAnosContribucao
            // 
            this.lblAnosContribucao.AutoSize = true;
            this.lblAnosContribucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnosContribucao.Location = new System.Drawing.Point(15, 144);
            this.lblAnosContribucao.Name = "lblAnosContribucao";
            this.lblAnosContribucao.Size = new System.Drawing.Size(135, 16);
            this.lblAnosContribucao.TabIndex = 6;
            this.lblAnosContribucao.Text = "Anos de Contribuição";
            // 
            // FrmCalculoAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculoAposentadoria";
            this.Text = "FrmCalculoAposentadoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAnoscontribucão;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbldatanascimento;
        private System.Windows.Forms.Label lblAnosContribucao;
    }
}