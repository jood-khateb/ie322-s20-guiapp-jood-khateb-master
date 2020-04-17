namespace Joud_Applecation
{
    partial class Combo
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
            this.slcMethod1 = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.RemoveIndex = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.remove2last = new System.Windows.Forms.Button();
            this.removeLast = new System.Windows.Forms.Button();
            this.slcMethod2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Metod3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slcMethod1
            // 
            this.slcMethod1.Location = new System.Drawing.Point(52, 29);
            this.slcMethod1.Name = "slcMethod1";
            this.slcMethod1.Size = new System.Drawing.Size(124, 72);
            this.slcMethod1.TabIndex = 0;
            this.slcMethod1.Text = "show selected method 1";
            this.slcMethod1.UseVisualStyleBackColor = true;
            this.slcMethod1.Click += new System.EventHandler(this.slcMethod1_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(203, 347);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(133, 67);
            this.RemoveName.TabIndex = 1;
            this.RemoveName.Text = "Remove by Name";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // RemoveIndex
            // 
            this.RemoveIndex.Location = new System.Drawing.Point(52, 347);
            this.RemoveIndex.Name = "RemoveIndex";
            this.RemoveIndex.Size = new System.Drawing.Size(124, 67);
            this.RemoveIndex.TabIndex = 2;
            this.RemoveIndex.Text = "Remove by index";
            this.RemoveIndex.UseVisualStyleBackColor = true;
            this.RemoveIndex.Click += new System.EventHandler(this.RemoveIndex_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(614, 379);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(102, 35);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // remove2last
            // 
            this.remove2last.Location = new System.Drawing.Point(614, 150);
            this.remove2last.Name = "remove2last";
            this.remove2last.Size = new System.Drawing.Size(102, 65);
            this.remove2last.TabIndex = 4;
            this.remove2last.Text = "remove 2nd last item";
            this.remove2last.UseVisualStyleBackColor = true;
            // 
            // removeLast
            // 
            this.removeLast.Location = new System.Drawing.Point(614, 241);
            this.removeLast.Name = "removeLast";
            this.removeLast.Size = new System.Drawing.Size(102, 72);
            this.removeLast.TabIndex = 5;
            this.removeLast.Text = "remove last item";
            this.removeLast.UseVisualStyleBackColor = true;
            this.removeLast.Click += new System.EventHandler(this.removeLast_Click);
            // 
            // slcMethod2
            // 
            this.slcMethod2.Location = new System.Drawing.Point(213, 29);
            this.slcMethod2.Name = "slcMethod2";
            this.slcMethod2.Size = new System.Drawing.Size(123, 72);
            this.slcMethod2.TabIndex = 6;
            this.slcMethod2.Text = "show selected method 2";
            this.slcMethod2.UseVisualStyleBackColor = true;
            this.slcMethod2.Click += new System.EventHandler(this.slcMethod2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Metod3
            // 
            this.Metod3.Location = new System.Drawing.Point(399, 29);
            this.Metod3.Name = "Metod3";
            this.Metod3.Size = new System.Drawing.Size(136, 72);
            this.Metod3.TabIndex = 8;
            this.Metod3.Text = "Show Selected Method3";
            this.Metod3.UseVisualStyleBackColor = true;
            this.Metod3.Click += new System.EventHandler(this.Metod3_Click);
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Metod3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.slcMethod2);
            this.Controls.Add(this.removeLast);
            this.Controls.Add(this.remove2last);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RemoveIndex);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.slcMethod1);
            this.Name = "Combo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button slcMethod1;
        private System.Windows.Forms.Button RemoveName;
        private System.Windows.Forms.Button RemoveIndex;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button remove2last;
        private System.Windows.Forms.Button removeLast;
        private System.Windows.Forms.Button slcMethod2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Metod3;
    }
}