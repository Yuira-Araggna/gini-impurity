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
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonShowGini = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewCSV
			// 
			this.dataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCSV.Location = new System.Drawing.Point(7, 53);
			this.dataGridViewCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridViewCSV.Name = "dataGridViewCSV";
			this.dataGridViewCSV.RowHeadersWidth = 51;
			this.dataGridViewCSV.RowTemplate.Height = 24;
			this.dataGridViewCSV.Size = new System.Drawing.Size(580, 308);
			this.dataGridViewCSV.TabIndex = 9;
			// 
			// buttonShow
			// 
			this.buttonShow.Location = new System.Drawing.Point(501, 11);
			this.buttonShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(86, 38);
			this.buttonShow.TabIndex = 8;
			this.buttonShow.Text = "Show File";
			this.buttonShow.UseVisualStyleBackColor = true;
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxOutput.Location = new System.Drawing.Point(7, 11);
			this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(368, 38);
			this.textBoxOutput.TabIndex = 7;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(409, 11);
			this.buttonLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(88, 38);
			this.buttonLoad.TabIndex = 6;
			this.buttonLoad.Text = "Load File";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonShowGini
			// 
			this.buttonShowGini.Location = new System.Drawing.Point(9, 379);
			this.buttonShowGini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonShowGini.Name = "buttonShowGini";
			this.buttonShowGini.Size = new System.Drawing.Size(88, 38);
			this.buttonShowGini.TabIndex = 10;
			this.buttonShowGini.Text = "Show Gini";
			this.buttonShowGini.UseVisualStyleBackColor = true;
			this.buttonShowGini.Click += new System.EventHandler(this.buttonShowGini_Click);
			// 
			// FormUtama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 426);
			this.Controls.Add(this.buttonShowGini);
			this.Controls.Add(this.dataGridViewCSV);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.buttonLoad);
			this.Name = "FormUtama";
			this.Text = "Form Utama";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewCSV;
		private System.Windows.Forms.Button buttonShow;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonShowGini;
    }
}

