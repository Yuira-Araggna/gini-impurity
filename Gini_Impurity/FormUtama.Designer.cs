namespace Gini_Impurity
{
    partial class FormUtama
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
            this.dataGridViewCSV = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonShowGini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCSV
            // 
            this.dataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSV.Location = new System.Drawing.Point(9, 65);
            this.dataGridViewCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCSV.Name = "dataGridViewCSV";
            this.dataGridViewCSV.RowHeadersWidth = 51;
            this.dataGridViewCSV.RowTemplate.Height = 24;
            this.dataGridViewCSV.Size = new System.Drawing.Size(773, 379);
            this.dataGridViewCSV.TabIndex = 9;
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Location = new System.Drawing.Point(135, 11);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(115, 47);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Show File";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 11);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(117, 47);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonShowGini
            // 
            this.buttonShowGini.Location = new System.Drawing.Point(12, 466);
            this.buttonShowGini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowGini.Name = "buttonShowGini";
            this.buttonShowGini.Size = new System.Drawing.Size(117, 47);
            this.buttonShowGini.TabIndex = 10;
            this.buttonShowGini.Text = "Show Gini";
            this.buttonShowGini.UseVisualStyleBackColor = true;
            this.buttonShowGini.Click += new System.EventHandler(this.buttonShowGini_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 524);
            this.Controls.Add(this.buttonShowGini);
            this.Controls.Add(this.dataGridViewCSV);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonLoad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewCSV;
		private System.Windows.Forms.Button buttonShow;
		private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonShowGini;
    }
}

