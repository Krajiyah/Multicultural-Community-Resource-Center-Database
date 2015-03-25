namespace MCRC_Database__Version_2_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.TextBox();
            this.ed = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Education";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(88, 148);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 21);
            this.country.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Occupation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country";
            // 
            // job
            // 
            this.job.FormattingEnabled = true;
            this.job.Location = new System.Drawing.Point(88, 114);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(121, 21);
            this.job.TabIndex = 7;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(88, 80);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 8;
            // 
            // ed
            // 
            this.ed.Location = new System.Drawing.Point(88, 50);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(100, 20);
            this.ed.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(88, 17);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 10;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(259, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 23);
            this.search.TabIndex = 11;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(259, 73);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 20);
            this.result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 202);
            this.Controls.Add(this.result);
            this.Controls.Add(this.search);
            this.Controls.Add(this.age);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.year);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MCRC Database (Version 2)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox job;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox ed;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox result;
    }
}

