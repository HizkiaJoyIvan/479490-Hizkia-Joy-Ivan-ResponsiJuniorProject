namespace TugasPraktik
{
    partial class FormComponent
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
            System.Windows.Forms.Label label1;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNo_handphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoaddata = new System.Windows.Forms.Button();
            this.btn_qr = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(342, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 0;
            label1.Text = "Data Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(156, 131);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 20);
            this.txtAlamat.TabIndex = 4;
            // 
            // txtNo_handphone
            // 
            this.txtNo_handphone.Location = new System.Drawing.Point(156, 169);
            this.txtNo_handphone.Name = "txtNo_handphone";
            this.txtNo_handphone.Size = new System.Drawing.Size(100, 20);
            this.txtNo_handphone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "No_Handphone";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(54, 245);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(478, 150);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(286, 97);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 100);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(408, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 100);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 100);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoaddata
            // 
            this.btnLoaddata.Location = new System.Drawing.Point(478, 412);
            this.btnLoaddata.Name = "btnLoaddata";
            this.btnLoaddata.Size = new System.Drawing.Size(75, 23);
            this.btnLoaddata.TabIndex = 11;
            this.btnLoaddata.Text = "Load Data";
            this.btnLoaddata.UseVisualStyleBackColor = true;
            this.btnLoaddata.Click += new System.EventHandler(this.btnLoaddata_Click);
            // 
            // btn_qr
            // 
            this.btn_qr.Location = new System.Drawing.Point(652, 97);
            this.btn_qr.Name = "btn_qr";
            this.btn_qr.Size = new System.Drawing.Size(116, 100);
            this.btn_qr.TabIndex = 12;
            this.btn_qr.Text = "Generate QR";
            this.btn_qr.UseVisualStyleBackColor = true;
            this.btn_qr.Click += new System.EventHandler(this.btn_qr_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_qr);
            this.Controls.Add(this.btnLoaddata);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtNo_handphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "FormComponent";
            this.Text = "FormComponent";
            this.Load += new System.EventHandler(this.FormComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoaddata;
        private System.Windows.Forms.Button btn_qr;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.TextBox txtNo_handphone;
    }
}