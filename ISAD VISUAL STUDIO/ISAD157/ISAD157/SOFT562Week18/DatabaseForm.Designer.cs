namespace SOFT562Week18
{
    partial class DatabaseForm
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
            this.dataGridViewFbusers = new System.Windows.Forms.DataGridView();
            this.dataGridViewFbfriends = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.dataGridViewUniversities = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkplace = new System.Windows.Forms.DataGridView();
            this.comboBoxQueryChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFbusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFbfriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFbusers
            // 
            this.dataGridViewFbusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFbusers.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewFbusers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFbusers.Name = "dataGridViewFbusers";
            this.dataGridViewFbusers.RowHeadersWidth = 51;
            this.dataGridViewFbusers.RowTemplate.Height = 24;
            this.dataGridViewFbusers.Size = new System.Drawing.Size(276, 301);
            this.dataGridViewFbusers.TabIndex = 0;
            // 
            // dataGridViewFbfriends
            // 
            this.dataGridViewFbfriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFbfriends.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewFbfriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFbfriends.Name = "dataGridViewFbfriends";
            this.dataGridViewFbfriends.RowHeadersWidth = 51;
            this.dataGridViewFbfriends.RowTemplate.Height = 24;
            this.dataGridViewFbfriends.Size = new System.Drawing.Size(276, 301);
            this.dataGridViewFbfriends.TabIndex = 0;
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(310, 12);
            this.dataGridViewMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.RowHeadersWidth = 51;
            this.dataGridViewMessages.RowTemplate.Height = 24;
            this.dataGridViewMessages.Size = new System.Drawing.Size(273, 301);
            this.dataGridViewMessages.TabIndex = 1;
            // 
            // dataGridViewUniversities
            // 
            this.dataGridViewUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversities.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewUniversities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewUniversities.Name = "dataGridViewUniversities";
            this.dataGridViewUniversities.RowHeadersWidth = 51;
            this.dataGridViewUniversities.RowTemplate.Height = 24;
            this.dataGridViewUniversities.Size = new System.Drawing.Size(276, 301);
            this.dataGridViewUniversities.TabIndex = 0;
            // 
            // dataGridViewWorkplace
            // 
            this.dataGridViewWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplace.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewWorkplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewWorkplace.Name = "dataGridViewWorkplace";
            this.dataGridViewWorkplace.RowHeadersWidth = 51;
            this.dataGridViewWorkplace.RowTemplate.Height = 24;
            this.dataGridViewWorkplace.Size = new System.Drawing.Size(276, 301);
            this.dataGridViewWorkplace.TabIndex = 0;
            // 
            // comboBoxQueryChoice
            // 
            this.comboBoxQueryChoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQueryChoice.FormattingEnabled = true;
            this.comboBoxQueryChoice.Items.AddRange(new object[] {
            "Fbusers",
            "Fbfriends",
            "Messages",
            "Universities",
            "Workplace"});
            this.comboBoxQueryChoice.Location = new System.Drawing.Point(15, 328);
            this.comboBoxQueryChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxQueryChoice.Name = "comboBoxQueryChoice";
            this.comboBoxQueryChoice.Size = new System.Drawing.Size(569, 29);
            this.comboBoxQueryChoice.TabIndex = 5;
            this.comboBoxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryChoice_SelectedIndexChanged);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBoxQueryChoice);
            this.Controls.Add(this.dataGridViewMessages);
            this.Controls.Add(this.dataGridViewFbusers);
            this.Controls.Add(this.dataGridViewFbfriends);
            this.Controls.Add(this.dataGridViewUniversities);
            this.Controls.Add(this.dataGridViewWorkplace);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DatabaseForm";
            this.Text = "Database Form Test";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFbusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFbfriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFbusers;
        private System.Windows.Forms.DataGridView dataGridViewFbfriends;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridView dataGridViewUniversities;
        private System.Windows.Forms.DataGridView dataGridViewWorkplace;
        private System.Windows.Forms.ComboBox comboBoxQueryChoice;
    }
}
