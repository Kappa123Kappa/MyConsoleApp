namespace WindowsFormsApp
{
    partial class MainForm
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.findStringButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aboutMethodsButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(6, 19);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(219, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 182);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // findStringButton
            // 
            this.findStringButton.Location = new System.Drawing.Point(119, 35);
            this.findStringButton.Name = "findStringButton";
            this.findStringButton.Size = new System.Drawing.Size(75, 23);
            this.findStringButton.TabIndex = 2;
            this.findStringButton.Text = "Find";
            this.findStringButton.UseVisualStyleBackColor = true;
            this.findStringButton.Click += new System.EventHandler(this.findStringButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.findStringButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find string in text";
            this.groupBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // aboutMethodsButton
            // 
            this.aboutMethodsButton.Location = new System.Drawing.Point(675, 22);
            this.aboutMethodsButton.Name = "aboutMethodsButton";
            this.aboutMethodsButton.Size = new System.Drawing.Size(113, 23);
            this.aboutMethodsButton.TabIndex = 3;
            this.aboutMethodsButton.Text = "About methods";
            this.aboutMethodsButton.UseVisualStyleBackColor = true;
            this.aboutMethodsButton.Click += new System.EventHandler(this.aboutMethodsButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(219, 230);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(450, 208);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openFileButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose text";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.aboutMethodsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button findStringButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aboutMethodsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

