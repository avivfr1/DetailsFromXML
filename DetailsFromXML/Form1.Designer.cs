using System.Drawing;

namespace DetailsFromXML
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.labelKod = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(668, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = ":שם";
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(511, 35);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(31, 17);
            this.labelKod.TabIndex = 0;
            this.labelKod.Text = ":קוד";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(548, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(391, 35);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(114, 22);
            this.textBoxKod.TabIndex = 1;
            // 
            // dataGridViewTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.EnableHeadersVisualStyles = false;
            this.dataGridViewTable.Location = new System.Drawing.Point(100, 83);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(597, 355);
            this.dataGridViewTable.TabIndex = 2;
            this.dataGridViewTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTable_ColumnHeaderMouseClick);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(286, 35);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 33);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "סנן";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "DetailsFromXML";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonFilter;
    }
}

