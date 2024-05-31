namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    partial class FormPolitaDeAsigurare
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAsigurare = new System.Windows.Forms.Label();
            this.labelInceput = new System.Windows.Forms.Label();
            this.labelSfarsit = new System.Windows.Forms.Label();
            this.comboBoxClienti = new System.Windows.Forms.ComboBox();
            this.comboBoxAsigurari = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInceput = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSfarsit = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPolite = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(61, 45);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(40, 16);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Client";
            // 
            // labelAsigurare
            // 
            this.labelAsigurare.AutoSize = true;
            this.labelAsigurare.Location = new System.Drawing.Point(61, 91);
            this.labelAsigurare.Name = "labelAsigurare";
            this.labelAsigurare.Size = new System.Drawing.Size(65, 16);
            this.labelAsigurare.TabIndex = 1;
            this.labelAsigurare.Text = "Asigurare";
            // 
            // labelInceput
            // 
            this.labelInceput.AutoSize = true;
            this.labelInceput.Location = new System.Drawing.Point(61, 131);
            this.labelInceput.Name = "labelInceput";
            this.labelInceput.Size = new System.Drawing.Size(82, 16);
            this.labelInceput.TabIndex = 2;
            this.labelInceput.Text = "Data inceput";
            // 
            // labelSfarsit
            // 
            this.labelSfarsit.AutoSize = true;
            this.labelSfarsit.Location = new System.Drawing.Point(61, 176);
            this.labelSfarsit.Name = "labelSfarsit";
            this.labelSfarsit.Size = new System.Drawing.Size(74, 16);
            this.labelSfarsit.TabIndex = 3;
            this.labelSfarsit.Text = "Data sfarsit";
            // 
            // comboBoxClienti
            // 
            this.comboBoxClienti.FormattingEnabled = true;
            this.comboBoxClienti.Location = new System.Drawing.Point(193, 37);
            this.comboBoxClienti.Name = "comboBoxClienti";
            this.comboBoxClienti.Size = new System.Drawing.Size(201, 24);
            this.comboBoxClienti.TabIndex = 4;
            // 
            // comboBoxAsigurari
            // 
            this.comboBoxAsigurari.FormattingEnabled = true;
            this.comboBoxAsigurari.Location = new System.Drawing.Point(193, 88);
            this.comboBoxAsigurari.Name = "comboBoxAsigurari";
            this.comboBoxAsigurari.Size = new System.Drawing.Size(201, 24);
            this.comboBoxAsigurari.TabIndex = 5;
            // 
            // dateTimePickerInceput
            // 
            this.dateTimePickerInceput.Location = new System.Drawing.Point(194, 131);
            this.dateTimePickerInceput.Name = "dateTimePickerInceput";
            this.dateTimePickerInceput.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInceput.TabIndex = 6;
            // 
            // dateTimePickerSfarsit
            // 
            this.dateTimePickerSfarsit.Location = new System.Drawing.Point(194, 176);
            this.dateTimePickerSfarsit.Name = "dateTimePickerSfarsit";
            this.dateTimePickerSfarsit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSfarsit.TabIndex = 7;
            // 
            // dataGridViewPolite
            // 
            this.dataGridViewPolite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolite.Location = new System.Drawing.Point(38, 233);
            this.dataGridViewPolite.Name = "dataGridViewPolite";
            this.dataGridViewPolite.RowHeadersWidth = 51;
            this.dataGridViewPolite.RowTemplate.Height = 24;
            this.dataGridViewPolite.Size = new System.Drawing.Size(723, 194);
            this.dataGridViewPolite.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(194, 462);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(413, 462);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 33);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormPolitaDeAsigurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewPolite);
            this.Controls.Add(this.dateTimePickerSfarsit);
            this.Controls.Add(this.dateTimePickerInceput);
            this.Controls.Add(this.comboBoxAsigurari);
            this.Controls.Add(this.comboBoxClienti);
            this.Controls.Add(this.labelSfarsit);
            this.Controls.Add(this.labelInceput);
            this.Controls.Add(this.labelAsigurare);
            this.Controls.Add(this.labelClient);
            this.Name = "FormPolitaDeAsigurare";
            this.Text = "FormPolitaDeAsigurare";
            this.Load += new System.EventHandler(this.FormPolitaDeAsigurare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAsigurare;
        private System.Windows.Forms.Label labelInceput;
        private System.Windows.Forms.Label labelSfarsit;
        private System.Windows.Forms.ComboBox comboBoxClienti;
        private System.Windows.Forms.ComboBox comboBoxAsigurari;
        private System.Windows.Forms.DateTimePicker dateTimePickerInceput;
        private System.Windows.Forms.DateTimePicker dateTimePickerSfarsit;
        private System.Windows.Forms.DataGridView dataGridViewPolite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}
