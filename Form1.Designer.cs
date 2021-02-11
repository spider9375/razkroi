
namespace Excel_App
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.templateBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.templateLbl = new System.Windows.Forms.Label();
            this.textLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // templateBtn
            // 
            this.templateBtn.Location = new System.Drawing.Point(23, 12);
            this.templateBtn.Name = "templateBtn";
            this.templateBtn.Size = new System.Drawing.Size(75, 23);
            this.templateBtn.TabIndex = 0;
            this.templateBtn.Text = "Шаблон";
            this.templateBtn.UseVisualStyleBackColor = true;
            this.templateBtn.Click += new System.EventHandler(this.templateBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Текстов файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Enabled = false;
            this.generateBtn.Location = new System.Drawing.Point(23, 130);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(185, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Генерирай";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // templateLbl
            // 
            this.templateLbl.Location = new System.Drawing.Point(23, 38);
            this.templateLbl.Name = "templateLbl";
            this.templateLbl.Size = new System.Drawing.Size(158, 23);
            this.templateLbl.TabIndex = 3;
            this.templateLbl.Click += new System.EventHandler(this.templateLbl_Click);
            // 
            // textLbl
            // 
            this.textLbl.Location = new System.Drawing.Point(23, 104);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(158, 23);
            this.textLbl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 166);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.templateLbl);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.templateBtn);
            this.Name = "Form1";
            this.Text = "Парсър";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button templateBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label templateLbl;
        private System.Windows.Forms.Label textLbl;
    }
}

