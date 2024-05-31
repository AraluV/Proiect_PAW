namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    partial class FormAsigurare
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
            this.dataGridViewAsigurari = new System.Windows.Forms.DataGridView();
            this.labelTipAsigurare = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.txtTipAsigurare = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsigurari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsigurari
            // 
            this.dataGridViewAsigurari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsigurari.Location = new System.Drawing.Point(31, 148);
            this.dataGridViewAsigurari.Name = "dataGridViewAsigurari";
            this.dataGridViewAsigurari.RowHeadersWidth = 51;
            this.dataGridViewAsigurari.RowTemplate.Height = 24;
            this.dataGridViewAsigurari.Size = new System.Drawing.Size(726, 210);
            this.dataGridViewAsigurari.TabIndex = 0;
            // 
            // labelTipAsigurare
            // 
            this.labelTipAsigurare.AutoSize = true;
            this.labelTipAsigurare.Location = new System.Drawing.Point(69, 37);
            this.labelTipAsigurare.Name = "labelTipAsigurare";
            this.labelTipAsigurare.Size = new System.Drawing.Size(87, 16);
            this.labelTipAsigurare.TabIndex = 1;
            this.labelTipAsigurare.Text = "Tip asigurare";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(69, 94);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(31, 16);
            this.labelPret.TabIndex = 2;
            this.labelPret.Text = "Pret";
            // 
            // txtTipAsigurare
            // 
            this.txtTipAsigurare.Location = new System.Drawing.Point(193, 34);
            this.txtTipAsigurare.Name = "txtTipAsigurare";
            this.txtTipAsigurare.Size = new System.Drawing.Size(200, 22);
            this.txtTipAsigurare.TabIndex = 3;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(193, 94);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(200, 22);
            this.txtPret.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(72, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(239, 398);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 33);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(439, 398);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 33);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(633, 398);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 33);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAsigurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtTipAsigurare);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelTipAsigurare);
            this.Controls.Add(this.dataGridViewAsigurari);
            this.Name = "FormAsigurare";
            this.Text = "FormAsigurare";
            this.Load += new System.EventHandler(this.FormAsigurare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsigurari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAsigurari;
        private System.Windows.Forms.Label labelTipAsigurare;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox txtTipAsigurare;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}