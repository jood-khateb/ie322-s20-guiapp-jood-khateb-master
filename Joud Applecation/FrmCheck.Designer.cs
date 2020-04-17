namespace Joud_Applecation
{
    partial class FrmCheck
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbrni = new System.Windows.Forms.CheckBox();
            this.chkDnt = new System.Windows.Forms.CheckBox();
            this.chkCfi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbrni);
            this.groupBox1.Controls.Add(this.chkDnt);
            this.groupBox1.Controls.Add(this.chkCfi);
            this.groupBox1.Location = new System.Drawing.Point(46, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkbrni
            // 
            this.chkbrni.AutoSize = true;
            this.chkbrni.Location = new System.Drawing.Point(32, 143);
            this.chkbrni.Name = "chkbrni";
            this.chkbrni.Size = new System.Drawing.Size(92, 23);
            this.chkbrni.TabIndex = 2;
            this.chkbrni.Text = "Brownie";
            this.chkbrni.UseVisualStyleBackColor = true;
            // 
            // chkDnt
            // 
            this.chkDnt.AutoSize = true;
            this.chkDnt.Location = new System.Drawing.Point(32, 91);
            this.chkDnt.Name = "chkDnt";
            this.chkDnt.Size = new System.Drawing.Size(78, 23);
            this.chkDnt.TabIndex = 1;
            this.chkDnt.Text = "Donut";
            this.chkDnt.UseVisualStyleBackColor = true;
            // 
            // chkCfi
            // 
            this.chkCfi.AutoSize = true;
            this.chkCfi.Location = new System.Drawing.Point(32, 43);
            this.chkCfi.Name = "chkCfi";
            this.chkCfi.Size = new System.Drawing.Size(80, 23);
            this.chkCfi.TabIndex = 0;
            this.chkCfi.Text = "Coffee";
            this.chkCfi.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmCheck";
            this.Text = "FrmCheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkbrni;
        private System.Windows.Forms.CheckBox chkDnt;
        private System.Windows.Forms.CheckBox chkCfi;
    }
}