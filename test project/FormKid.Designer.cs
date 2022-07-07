namespace test_project
{
    partial class FormKid
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddKids = new System.Windows.Forms.Button();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(208, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(585, 238);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kid ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name Kid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sex";
            // 
            // dateTimeOfBirth
            // 
            this.dateTimeOfBirth.CustomFormat = "dd-mm-yyy";
            this.dateTimeOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOfBirth.Location = new System.Drawing.Point(91, 146);
            this.dateTimeOfBirth.Name = "dateTimeOfBirth";
            this.dateTimeOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dateTimeOfBirth.TabIndex = 8;
            this.dateTimeOfBirth.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Of Birth";
            // 
            // btnAddKids
            // 
            this.btnAddKids.Location = new System.Drawing.Point(71, 218);
            this.btnAddKids.Name = "btnAddKids";
            this.btnAddKids.Size = new System.Drawing.Size(75, 23);
            this.btnAddKids.TabIndex = 10;
            this.btnAddKids.Text = "ADD";
            this.btnAddKids.UseVisualStyleBackColor = true;
            this.btnAddKids.Click += new System.EventHandler(this.btnAddKids_Click);
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboSex.Location = new System.Drawing.Point(71, 114);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(121, 21);
            this.comboSex.TabIndex = 11;
            this.comboSex.Text = "         Select Sex";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(71, 53);
            this.txtId.MaxLength = 2;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 12;
            // 
            // FormKid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 397);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.btnAddKids);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "FormKid";
            this.Text = "FormKid";
            this.Load += new System.EventHandler(this.FormKid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddKids;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.TextBox txtId;
    }
}