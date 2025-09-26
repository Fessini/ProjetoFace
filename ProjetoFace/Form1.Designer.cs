namespace ProjetoFace
{
    partial class Form1
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnTreinarModelo = new System.Windows.Forms.Button();
            this.btnReconhecer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(69, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Confirmação ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Colaborador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 282);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(136, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // btnTreinarModelo
            // 
            this.btnTreinarModelo.Location = new System.Drawing.Point(15, 337);
            this.btnTreinarModelo.Name = "btnTreinarModelo";
            this.btnTreinarModelo.Size = new System.Drawing.Size(136, 23);
            this.btnTreinarModelo.TabIndex = 4;
            this.btnTreinarModelo.Text = "Treinar Modelo";
            this.btnTreinarModelo.UseVisualStyleBackColor = true;
            this.btnTreinarModelo.Click += new System.EventHandler(this.btnTreinarModelo_Click);
            // 
            // btnReconhecer
            // 
            this.btnReconhecer.Location = new System.Drawing.Point(15, 366);
            this.btnReconhecer.Name = "btnReconhecer";
            this.btnReconhecer.Size = new System.Drawing.Size(136, 23);
            this.btnReconhecer.TabIndex = 5;
            this.btnReconhecer.Text = "Reconhecer";
            this.btnReconhecer.UseVisualStyleBackColor = true;
            this.btnReconhecer.Click += new System.EventHandler(this.btnReconhecer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "<< ID do colaborador.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReconhecer);
            this.Controls.Add(this.btnTreinarModelo);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconhecimento Facial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnTreinarModelo;
        private System.Windows.Forms.Button btnReconhecer;
        private System.Windows.Forms.Label label1;
    }
}

