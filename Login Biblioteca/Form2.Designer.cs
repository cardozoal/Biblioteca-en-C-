
namespace Login_Biblioteca
{
    partial class Form2
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
            this.pbrinicio = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrcarga = new System.Windows.Forms.Timer(this.components);
            this.lblcarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbrinicio
            // 
            this.pbrinicio.Location = new System.Drawing.Point(213, 240);
            this.pbrinicio.Name = "pbrinicio";
            this.pbrinicio.Size = new System.Drawing.Size(189, 36);
            this.pbrinicio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrinicio.TabIndex = 0;
            this.pbrinicio.Click += new System.EventHandler(this.pbrinicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido a la Biblioteca Virtual!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por favor, espere unos segundos mientras el sistema inicia...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tmrcarga
            // 
            this.tmrcarga.Interval = 3000;
            this.tmrcarga.Tick += new System.EventHandler(this.tmrcarga_Tick);
            // 
            // lblcarga
            // 
            this.lblcarga.AutoSize = true;
            this.lblcarga.Location = new System.Drawing.Point(310, 312);
            this.lblcarga.Name = "lblcarga";
            this.lblcarga.Size = new System.Drawing.Size(10, 13);
            this.lblcarga.TabIndex = 3;
            this.lblcarga.Text = ".";
            this.lblcarga.Click += new System.EventHandler(this.lblcarga_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblcarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrinicio);
            this.Name = "Form2";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrcarga;
        private System.Windows.Forms.Label lblcarga;
    }
}