namespace Gini_Impurity
{
    partial class FormGini
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
			this.textBoxF1 = new System.Windows.Forms.TextBox();
			this.textBoxF2 = new System.Windows.Forms.TextBox();
			this.textBoxFeat3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxF1
			// 
			this.textBoxF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxF1.Location = new System.Drawing.Point(134, 10);
			this.textBoxF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxF1.Name = "textBoxF1";
			this.textBoxF1.ReadOnly = true;
			this.textBoxF1.Size = new System.Drawing.Size(106, 38);
			this.textBoxF1.TabIndex = 8;
			// 
			// textBoxF2
			// 
			this.textBoxF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxF2.Location = new System.Drawing.Point(134, 76);
			this.textBoxF2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxF2.Name = "textBoxF2";
			this.textBoxF2.ReadOnly = true;
			this.textBoxF2.Size = new System.Drawing.Size(106, 38);
			this.textBoxF2.TabIndex = 9;
			// 
			// textBoxFeat3
			// 
			this.textBoxFeat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFeat3.Location = new System.Drawing.Point(134, 153);
			this.textBoxFeat3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxFeat3.Name = "textBoxFeat3";
			this.textBoxFeat3.ReadOnly = true;
			this.textBoxFeat3.Size = new System.Drawing.Size(106, 38);
			this.textBoxFeat3.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 41);
			this.label1.TabIndex = 11;
			this.label1.Text = "Gini Feat 1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 41);
			this.label2.TabIndex = 12;
			this.label2.Text = "Gini Feat 2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 153);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 41);
			this.label3.TabIndex = 13;
			this.label3.Text = "Gini Feat 3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.AutoSize = true;
			this.buttonCalculate.Location = new System.Drawing.Point(41, 224);
			this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(91, 53);
			this.buttonCalculate.TabIndex = 14;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.AutoSize = true;
			this.buttonSave.Location = new System.Drawing.Point(149, 224);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(91, 53);
			this.buttonSave.TabIndex = 15;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormGini
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 303);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxFeat3);
			this.Controls.Add(this.textBoxF2);
			this.Controls.Add(this.textBoxF1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormGini";
			this.Text = "FormGini";
			this.Load += new System.EventHandler(this.FormGini_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.TextBox textBoxFeat3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSave;
    }
}