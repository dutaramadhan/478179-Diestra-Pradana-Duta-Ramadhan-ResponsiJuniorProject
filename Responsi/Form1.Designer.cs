namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblLogo = new System.Windows.Forms.Label();
            lblNamaKaryawan = new System.Windows.Forms.Label();
            lblDepKaryawan = new System.Windows.Forms.Label();
            btnInsert = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            tbNamaKaryawan = new System.Windows.Forms.TextBox();
            cbDepKaryawan = new System.Windows.Forms.ComboBox();
            dvgData = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvgData).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new System.Drawing.Point(33, 29);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(34, 15);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Logo";
            // 
            // lblNamaKaryawan
            // 
            lblNamaKaryawan.AutoSize = true;
            lblNamaKaryawan.Location = new System.Drawing.Point(12, 73);
            lblNamaKaryawan.Name = "lblNamaKaryawan";
            lblNamaKaryawan.Size = new System.Drawing.Size(99, 15);
            lblNamaKaryawan.TabIndex = 1;
            lblNamaKaryawan.Text = "Nama Karyawan :";
            // 
            // lblDepKaryawan
            // 
            lblDepKaryawan.AutoSize = true;
            lblDepKaryawan.Location = new System.Drawing.Point(12, 107);
            lblDepKaryawan.Name = "lblDepKaryawan";
            lblDepKaryawan.Size = new System.Drawing.Size(97, 15);
            lblDepKaryawan.TabIndex = 2;
            lblDepKaryawan.Text = "Dep. Karyawan   :";
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(39, 161);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(75, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(171, 161);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(306, 161);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new System.Drawing.Point(117, 70);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new System.Drawing.Size(119, 23);
            tbNamaKaryawan.TabIndex = 6;
            // 
            // cbDepKaryawan
            // 
            cbDepKaryawan.FormattingEnabled = true;
            cbDepKaryawan.Location = new System.Drawing.Point(115, 104);
            cbDepKaryawan.Name = "cbDepKaryawan";
            cbDepKaryawan.Size = new System.Drawing.Size(121, 23);
            cbDepKaryawan.TabIndex = 7;
            // 
            // dvgData
            // 
            dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgData.Location = new System.Drawing.Point(12, 207);
            dvgData.Name = "dvgData";
            dvgData.RowTemplate.Height = 25;
            dvgData.Size = new System.Drawing.Size(369, 230);
            dvgData.TabIndex = 8;
            dvgData.CellClick += dvgData_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            groupBox1.Location = new System.Drawing.Point(242, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(139, 126);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Departemen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(393, 444);
            Controls.Add(groupBox1);
            Controls.Add(dvgData);
            Controls.Add(cbDepKaryawan);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(lblDepKaryawan);
            Controls.Add(lblNamaKaryawan);
            Controls.Add(lblLogo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblNamaKaryawan;
        private System.Windows.Forms.Label lblDepKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbNamaKaryawan;
        private System.Windows.Forms.ComboBox cbDepKaryawan;
        private System.Windows.Forms.DataGridView dvgData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
