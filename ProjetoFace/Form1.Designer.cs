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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(45, 39);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(213, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(195, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // btnTreinarModelo
            // 
            this.btnTreinarModelo.Location = new System.Drawing.Point(345, 352);
            this.btnTreinarModelo.Name = "btnTreinarModelo";
            this.btnTreinarModelo.Size = new System.Drawing.Size(161, 23);
            this.btnTreinarModelo.TabIndex = 4;
            this.btnTreinarModelo.Text = "Treinar Modelo";
            this.btnTreinarModelo.UseVisualStyleBackColor = true;
            this.btnTreinarModelo.Click += new System.EventHandler(this.btnTreinarModelo_Click);
            // 
            // btnReconhecer
            // 
            this.btnReconhecer.Location = new System.Drawing.Point(530, 364);
            this.btnReconhecer.Name = "btnReconhecer";
            this.btnReconhecer.Size = new System.Drawing.Size(75, 23);
            this.btnReconhecer.TabIndex = 5;
            this.btnReconhecer.Text = "Reconhecer";
            this.btnReconhecer.UseVisualStyleBackColor = true;
            this.btnReconhecer.Click += new System.EventHandler(this.btnReconhecer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReconhecer);
            this.Controls.Add(this.btnTreinarModelo);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

