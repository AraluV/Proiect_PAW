namespace REST_1058_VLAD_RALUCA_ALECSANDRA
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
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAsigurare = new System.Windows.Forms.Button();
            this.buttonPolita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(228, 74);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(199, 53);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAsigurare
            // 
            this.buttonAsigurare.Location = new System.Drawing.Point(238, 171);
            this.buttonAsigurare.Name = "buttonAsigurare";
            this.buttonAsigurare.Size = new System.Drawing.Size(199, 53);
            this.buttonAsigurare.TabIndex = 1;
            this.buttonAsigurare.Text = "Asigurare";
            this.buttonAsigurare.UseVisualStyleBackColor = true;
            this.buttonAsigurare.Click += new System.EventHandler(this.buttonAsigurare_Click);
            // 
            // buttonPolita
            // 
            this.buttonPolita.Location = new System.Drawing.Point(238, 274);
            this.buttonPolita.Name = "buttonPolita";
            this.buttonPolita.Size = new System.Drawing.Size(199, 53);
            this.buttonPolita.TabIndex = 2;
            this.buttonPolita.Text = "Polita de asigurare";
            this.buttonPolita.UseVisualStyleBackColor = true;
            this.buttonPolita.Click += new System.EventHandler(this.buttonPolita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPolita);
            this.Controls.Add(this.buttonAsigurare);
            this.Controls.Add(this.buttonClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAsigurare;
        private System.Windows.Forms.Button buttonPolita;
    }
}

