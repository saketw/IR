﻿namespace IR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passengerName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPreference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iRdbDataSet = new IR.IRdbDataSet();
            this.familyTableAdapter = new IR.IRdbDataSetTableAdapters.FamilyTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTotalPassengers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.passengerName,
            this.age,
            this.Gender,
            this.BirthPreference,
            this.idcard,
            this.idcardNumber});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Family Name";
            this.Column1.Name = "Column1";
            // 
            // passengerName
            // 
            this.passengerName.HeaderText = "Name";
            this.passengerName.Name = "passengerName";
            this.passengerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.passengerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // BirthPreference
            // 
            this.BirthPreference.HeaderText = "Bearth Preference";
            this.BirthPreference.Name = "BirthPreference";
            // 
            // idcard
            // 
            this.idcard.HeaderText = "ID Card";
            this.idcard.Name = "idcard";
            // 
            // idcardNumber
            // 
            this.idcardNumber.HeaderText = "ID Card Number";
            this.idcardNumber.Name = "idcardNumber";
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.iRdbDataSet;
            // 
            // iRdbDataSet
            // 
            this.iRdbDataSet.DataSetName = "IRdbDataSet";
            this.iRdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total passengers for this trip";
            // 
            // cbTotalPassengers
            // 
            this.cbTotalPassengers.FormattingEnabled = true;
            this.cbTotalPassengers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbTotalPassengers.Location = new System.Drawing.Point(341, 22);
            this.cbTotalPassengers.Name = "cbTotalPassengers";
            this.cbTotalPassengers.Size = new System.Drawing.Size(65, 21);
            this.cbTotalPassengers.TabIndex = 2;
            this.cbTotalPassengers.SelectedIndexChanged += new System.EventHandler(this.onSelChangeTotalPassengers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 304);
            this.Controls.Add(this.cbTotalPassengers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IRdbDataSet iRdbDataSet;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private IRdbDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTotalPassengers;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn passengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPreference;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcardNumber;
    }
}

