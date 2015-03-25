namespace MCRC_Client_Database
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
            this.label2 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dt = new System.Windows.Forms.TextBox();
            this.Ed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Occupation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ct1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ct2 = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label9 = new System.Windows.Forms.Label();
            this.agefilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.occupationfilter = new System.Windows.Forms.ComboBox();
            this.educationfilter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.countryfilter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country of Origin";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(44, 34);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(59, 20);
            this.Age.TabIndex = 2;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(103, 63);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(59, 20);
            this.Country.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Intake (year)";
            // 
            // Dt
            // 
            this.Dt.Location = new System.Drawing.Point(122, 103);
            this.Dt.Name = "Dt";
            this.Dt.Size = new System.Drawing.Size(59, 20);
            this.Dt.TabIndex = 5;
            // 
            // Ed
            // 
            this.Ed.Location = new System.Drawing.Point(103, 150);
            this.Ed.Name = "Ed";
            this.Ed.Size = new System.Drawing.Size(59, 20);
            this.Ed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Educational Level";
            // 
            // Occupation
            // 
            this.Occupation.Location = new System.Drawing.Point(80, 190);
            this.Occupation.Name = "Occupation";
            this.Occupation.Size = new System.Drawing.Size(59, 20);
            this.Occupation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Occupation";
            // 
            // Ct1
            // 
            this.Ct1.FormattingEnabled = true;
            this.Ct1.Items.AddRange(new object[] {
            "Age",
            "Country of Origin",
            "Educational Level",
            "Occupation",
            "Total People"});
            this.Ct1.Location = new System.Drawing.Point(248, 6);
            this.Ct1.Name = "Ct1";
            this.Ct1.Size = new System.Drawing.Size(92, 21);
            this.Ct1.TabIndex = 10;
            this.Ct1.SelectedIndexChanged += new System.EventHandler(this.Ct1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Criterion";
            // 
            // Ct2
            // 
            this.Ct2.FormattingEnabled = true;
            this.Ct2.Location = new System.Drawing.Point(248, 37);
            this.Ct2.Name = "Ct2";
            this.Ct2.Size = new System.Drawing.Size(92, 21);
            this.Ct2.TabIndex = 12;
            this.Ct2.SelectedIndexChanged += new System.EventHandler(this.Ct2_SelectedIndexChanged);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(413, 6);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(76, 20);
            this.Total.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(145, 178);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(42, 42);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(74, 6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 20);
            this.id.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID number";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(535, 236);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 190;
            this.lineShape2.X2 = 190;
            this.lineShape2.Y1 = 213;
            this.lineShape2.Y2 = 6;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 215;
            this.lineShape1.X2 = 488;
            this.lineShape1.Y1 = 84;
            this.lineShape1.Y2 = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Age Range";
            // 
            // agefilter
            // 
            this.agefilter.FormattingEnabled = true;
            this.agefilter.Items.AddRange(new object[] {
            "0-9",
            "10-19",
            "20-29",
            "30-39",
            "40-49",
            "50-59",
            "60-69",
            "70-79",
            "80-89"});
            this.agefilter.Location = new System.Drawing.Point(264, 103);
            this.agefilter.Name = "agefilter";
            this.agefilter.Size = new System.Drawing.Size(92, 21);
            this.agefilter.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Occupation";
            // 
            // occupationfilter
            // 
            this.occupationfilter.FormattingEnabled = true;
            this.occupationfilter.Location = new System.Drawing.Point(265, 134);
            this.occupationfilter.Name = "occupationfilter";
            this.occupationfilter.Size = new System.Drawing.Size(92, 21);
            this.occupationfilter.TabIndex = 25;
            // 
            // educationfilter
            // 
            this.educationfilter.Location = new System.Drawing.Point(264, 168);
            this.educationfilter.Name = "educationfilter";
            this.educationfilter.Size = new System.Drawing.Size(92, 20);
            this.educationfilter.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Education";
            // 
            // countryfilter
            // 
            this.countryfilter.FormattingEnabled = true;
            this.countryfilter.Location = new System.Drawing.Point(429, 103);
            this.countryfilter.Name = "countryfilter";
            this.countryfilter.Size = new System.Drawing.Size(92, 21);
            this.countryfilter.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Country";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(419, 180);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(66, 27);
            this.search.TabIndex = 30;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Result";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Year";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(264, 193);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(92, 20);
            this.year.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 236);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.countryfilter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.educationfilter);
            this.Controls.Add(this.occupationfilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.agefilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Ct2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ct1);
            this.Controls.Add(this.Occupation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MCRC Client Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dt;
        private System.Windows.Forms.TextBox Ed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Occupation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Ct1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Ct2;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox agefilter;
        private System.Windows.Forms.Label label10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ComboBox occupationfilter;
        private System.Windows.Forms.TextBox educationfilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox countryfilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox year;
    }
}

