namespace CheckSumControl
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
            this.Reset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChckSumControl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtResultFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWellForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(32, 310);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(164, 53);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 178);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 58);
            this.textBox1.TabIndex = 6;
            // 
            // btnChckSumControl
            // 
            this.btnChckSumControl.Location = new System.Drawing.Point(32, 178);
            this.btnChckSumControl.Name = "btnChckSumControl";
            this.btnChckSumControl.Size = new System.Drawing.Size(164, 29);
            this.btnChckSumControl.TabIndex = 5;
            this.btnChckSumControl.Text = "Run check sum control";
            this.btnChckSumControl.UseVisualStyleBackColor = true;
            this.btnChckSumControl.Click += new System.EventHandler(this.btnWellFormControl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 69);
            this.listBox1.TabIndex = 4;
            // 
            // txtResultFolder
            // 
            this.txtResultFolder.Location = new System.Drawing.Point(111, 145);
            this.txtResultFolder.Name = "txtResultFolder";
            this.txtResultFolder.Size = new System.Drawing.Size(457, 20);
            this.txtResultFolder.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result folder";
            // 
            // btnWellForm
            // 
            this.btnWellForm.Location = new System.Drawing.Point(32, 213);
            this.btnWellForm.Name = "btnWellForm";
            this.btnWellForm.Size = new System.Drawing.Size(164, 28);
            this.btnWellForm.TabIndex = 10;
            this.btnWellForm.Text = "Control if well formed";
            this.btnWellForm.UseVisualStyleBackColor = true;
            this.btnWellForm.Click += new System.EventHandler(this.btnWellForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnWellForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultFolder);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChckSumControl);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChckSumControl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtResultFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWellForm;
    }
}

