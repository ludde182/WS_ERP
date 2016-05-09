namespace ERPForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.dataGridViewERP = new System.Windows.Forms.DataGridView();
            this.comboBoxMetaData = new System.Windows.Forms.ComboBox();
            this.labelMetaData = new System.Windows.Forms.Label();
            this.buttonMetaData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonConfirmInsert = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewERP)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(796, 183);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(152, 22);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate Table";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // dataGridViewERP
            // 
            this.dataGridViewERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewERP.Location = new System.Drawing.Point(12, 211);
            this.dataGridViewERP.MultiSelect = false;
            this.dataGridViewERP.Name = "dataGridViewERP";
            this.dataGridViewERP.Size = new System.Drawing.Size(936, 483);
            this.dataGridViewERP.TabIndex = 2;
            // 
            // comboBoxMetaData
            // 
            this.comboBoxMetaData.FormattingEnabled = true;
            this.comboBoxMetaData.Location = new System.Drawing.Point(12, 184);
            this.comboBoxMetaData.Name = "comboBoxMetaData";
            this.comboBoxMetaData.Size = new System.Drawing.Size(256, 21);
            this.comboBoxMetaData.TabIndex = 3;
            // 
            // labelMetaData
            // 
            this.labelMetaData.AutoSize = true;
            this.labelMetaData.Location = new System.Drawing.Point(9, 168);
            this.labelMetaData.Name = "labelMetaData";
            this.labelMetaData.Size = new System.Drawing.Size(120, 13);
            this.labelMetaData.TabIndex = 4;
            this.labelMetaData.Text = "Please select metadata:";
            // 
            // buttonMetaData
            // 
            this.buttonMetaData.Location = new System.Drawing.Point(274, 185);
            this.buttonMetaData.Name = "buttonMetaData";
            this.buttonMetaData.Size = new System.Drawing.Size(152, 20);
            this.buttonMetaData.TabIndex = 5;
            this.buttonMetaData.Text = "Show MetaData";
            this.buttonMetaData.UseVisualStyleBackColor = true;
            this.buttonMetaData.Click += new System.EventHandler(this.buttonMetaData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please select employee data:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(662, 700);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 30);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(808, 700);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 30);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(516, 700);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(140, 30);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert Into Table";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonConfirmInsert
            // 
            this.buttonConfirmInsert.Location = new System.Drawing.Point(516, 700);
            this.buttonConfirmInsert.Name = "buttonConfirmInsert";
            this.buttonConfirmInsert.Size = new System.Drawing.Size(140, 30);
            this.buttonConfirmInsert.TabIndex = 10;
            this.buttonConfirmInsert.Text = "Insert Confirm";
            this.buttonConfirmInsert.UseVisualStyleBackColor = true;
            this.buttonConfirmInsert.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Location = new System.Drawing.Point(464, 801);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(496, 21);
            this.labelMessage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 831);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonConfirmInsert);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMetaData);
            this.Controls.Add(this.labelMetaData);
            this.Controls.Add(this.comboBoxMetaData);
            this.Controls.Add(this.dataGridViewERP);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewERP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.DataGridView dataGridViewERP;
        private System.Windows.Forms.ComboBox comboBoxMetaData;
        private System.Windows.Forms.Label labelMetaData;
        private System.Windows.Forms.Button buttonMetaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonConfirmInsert;
        private System.Windows.Forms.Label labelMessage;
    }
}

