namespace PRG2_20202_P5_1_2_07
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProdi = new System.Windows.Forms.DataGridView();
            this.msprodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProdi1 = new PRG2_20202_P5_1_2_07.dsProdi1();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.msprodiTableAdapter = new PRG2_20202_P5_1_2_07.dsProdi1TableAdapters.msprodiTableAdapter();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdi1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM VIEW UPDATE PRODI";
            // 
            // dgProdi
            // 
            this.dgProdi.AutoGenerateColumns = false;
            this.dgProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn,
            this.singkatanDataGridViewTextBoxColumn,
            this.kaprodiDataGridViewTextBoxColumn,
            this.sekprodiDataGridViewTextBoxColumn});
            this.dgProdi.DataSource = this.msprodiBindingSource;
            this.dgProdi.Location = new System.Drawing.Point(25, 86);
            this.dgProdi.Name = "dgProdi";
            this.dgProdi.RowTemplate.Height = 28;
            this.dgProdi.Size = new System.Drawing.Size(859, 245);
            this.dgProdi.TabIndex = 1;
            // 
            // msprodiBindingSource
            // 
            this.msprodiBindingSource.DataMember = "msprodi";
            this.msprodiBindingSource.DataSource = this.dsProdi1;
            // 
            // dsProdi1
            // 
            this.dsProdi1.DataSetName = "dsProdi1";
            this.dsProdi1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(317, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // msprodiTableAdapter
            // 
            this.msprodiTableAdapter.ClearBeforeFill = true;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "ID Prodi";
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "Nama Prodi";
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            // 
            // singkatanDataGridViewTextBoxColumn
            // 
            this.singkatanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.singkatanDataGridViewTextBoxColumn.DataPropertyName = "singkatan";
            this.singkatanDataGridViewTextBoxColumn.HeaderText = "Singkatan";
            this.singkatanDataGridViewTextBoxColumn.Name = "singkatanDataGridViewTextBoxColumn";
            // 
            // kaprodiDataGridViewTextBoxColumn
            // 
            this.kaprodiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kaprodiDataGridViewTextBoxColumn.DataPropertyName = "ka_prodi";
            this.kaprodiDataGridViewTextBoxColumn.HeaderText = "Ketua Prodi";
            this.kaprodiDataGridViewTextBoxColumn.Name = "kaprodiDataGridViewTextBoxColumn";
            // 
            // sekprodiDataGridViewTextBoxColumn
            // 
            this.sekprodiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sekprodiDataGridViewTextBoxColumn.DataPropertyName = "sek_prodi";
            this.sekprodiDataGridViewTextBoxColumn.HeaderText = "Sekretaris Prodi";
            this.sekprodiDataGridViewTextBoxColumn.Name = "sekprodiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 468);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgProdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProdi;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private dsProdi1 dsProdi1;
        private System.Windows.Forms.BindingSource msprodiBindingSource;
        private dsProdi1TableAdapters.msprodiTableAdapter msprodiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekprodiDataGridViewTextBoxColumn;
    }
}

