namespace Horran_Appartments_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.total_ged = new System.Windows.Forms.Label();
            this.total_esl = new System.Windows.Forms.Label();
            this.total_emp = new System.Windows.Forms.Label();
            this.enrollment = new System.Windows.Forms.CheckedListBox();
            this.qualifications = new System.Windows.Forms.CheckedListBox();
            this.levelged = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.levelesl = new System.Windows.Forms.CheckedListBox();
            this.levelemp = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelmaker = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cell = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.dellabel = new System.Windows.Forms.Button();
            this.printLabels = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.delAll = new System.Windows.Forms.Button();
            this.viewLabels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // total_ged
            // 
            this.total_ged.AutoSize = true;
            this.total_ged.BackColor = System.Drawing.Color.PaleTurquoise;
            this.total_ged.Location = new System.Drawing.Point(16, 332);
            this.total_ged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_ged.Name = "total_ged";
            this.total_ged.Size = new System.Drawing.Size(78, 17);
            this.total_ged.TabIndex = 1;
            this.total_ged.Text = "Total GED:";
            // 
            // total_esl
            // 
            this.total_esl.AutoSize = true;
            this.total_esl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.total_esl.Location = new System.Drawing.Point(151, 332);
            this.total_esl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_esl.Name = "total_esl";
            this.total_esl.Size = new System.Drawing.Size(74, 17);
            this.total_esl.TabIndex = 2;
            this.total_esl.Text = "Total ESL:";
            // 
            // total_emp
            // 
            this.total_emp.AutoSize = true;
            this.total_emp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.total_emp.Location = new System.Drawing.Point(15, 367);
            this.total_emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_emp.Name = "total_emp";
            this.total_emp.Size = new System.Drawing.Size(125, 17);
            this.total_emp.TabIndex = 3;
            this.total_emp.Text = "Total Employment:";
            // 
            // enrollment
            // 
            this.enrollment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.enrollment.FormattingEnabled = true;
            this.enrollment.Items.AddRange(new object[] {
            "GED",
            "ESL",
            "Employment"});
            this.enrollment.Location = new System.Drawing.Point(301, 15);
            this.enrollment.Margin = new System.Windows.Forms.Padding(4);
            this.enrollment.Name = "enrollment";
            this.enrollment.Size = new System.Drawing.Size(151, 55);
            this.enrollment.TabIndex = 4;
            // 
            // qualifications
            // 
            this.qualifications.BackColor = System.Drawing.Color.PaleTurquoise;
            this.qualifications.FormattingEnabled = true;
            this.qualifications.Items.AddRange(new object[] {
            "Drivers License",
            "Employed",
            "High School",
            "Some College",
            "College"});
            this.qualifications.Location = new System.Drawing.Point(301, 82);
            this.qualifications.Margin = new System.Windows.Forms.Padding(4);
            this.qualifications.Name = "qualifications";
            this.qualifications.Size = new System.Drawing.Size(151, 89);
            this.qualifications.TabIndex = 5;
            // 
            // levelged
            // 
            this.levelged.BackColor = System.Drawing.Color.PaleTurquoise;
            this.levelged.FormattingEnabled = true;
            this.levelged.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.levelged.Location = new System.Drawing.Point(301, 210);
            this.levelged.Margin = new System.Windows.Forms.Padding(4);
            this.levelged.Name = "levelged";
            this.levelged.Size = new System.Drawing.Size(151, 89);
            this.levelged.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(460, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address:";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.PaleTurquoise;
            this.address.Location = new System.Drawing.Point(532, 41);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(132, 22);
            this.address.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.PaleTurquoise;
            this.phone.Location = new System.Drawing.Point(532, 72);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(132, 22);
            this.phone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(460, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone #:";
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.Color.PaleTurquoise;
            this.skills.Location = new System.Drawing.Point(528, 102);
            this.skills.Margin = new System.Windows.Forms.Padding(4);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(341, 22);
            this.skills.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(465, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Skills:";
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.notes.Location = new System.Drawing.Point(461, 151);
            this.notes.Margin = new System.Windows.Forms.Padding(4);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(232, 137);
            this.notes.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(547, 128);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Notes:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(676, 320);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 28);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(676, 353);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(84, 28);
            this.update.TabIndex = 17;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(676, 388);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 28);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // levelesl
            // 
            this.levelesl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.levelesl.FormattingEnabled = true;
            this.levelesl.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.levelesl.Location = new System.Drawing.Point(301, 331);
            this.levelesl.Margin = new System.Windows.Forms.Padding(4);
            this.levelesl.Name = "levelesl";
            this.levelesl.Size = new System.Drawing.Size(151, 89);
            this.levelesl.TabIndex = 19;
            // 
            // levelemp
            // 
            this.levelemp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.levelemp.FormattingEnabled = true;
            this.levelemp.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.levelemp.Location = new System.Drawing.Point(461, 331);
            this.levelemp.Margin = new System.Windows.Forms.Padding(4);
            this.levelemp.Name = "levelemp";
            this.levelemp.Size = new System.Drawing.Size(151, 89);
            this.levelemp.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(355, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "GED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(492, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Employment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(355, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "ESL";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.PaleTurquoise;
            this.name.Location = new System.Drawing.Point(532, 11);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 22);
            this.name.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Location = new System.Drawing.Point(460, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Name:";
            // 
            // labelmaker
            // 
            this.labelmaker.Location = new System.Drawing.Point(645, 424);
            this.labelmaker.Margin = new System.Windows.Forms.Padding(4);
            this.labelmaker.Name = "labelmaker";
            this.labelmaker.Size = new System.Drawing.Size(138, 28);
            this.labelmaker.TabIndex = 26;
            this.labelmaker.Text = "Add Mailing Label";
            this.labelmaker.UseVisualStyleBackColor = true;
            this.labelmaker.Click += new System.EventHandler(this.print_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Location = new System.Drawing.Point(761, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "City:";
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.PaleTurquoise;
            this.city.Location = new System.Drawing.Point(805, 8);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(67, 22);
            this.city.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Location = new System.Drawing.Point(761, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Zip:";
            // 
            // zip
            // 
            this.zip.BackColor = System.Drawing.Color.PaleTurquoise;
            this.zip.Location = new System.Drawing.Point(802, 40);
            this.zip.Margin = new System.Windows.Forms.Padding(4);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(67, 22);
            this.zip.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label10.Location = new System.Drawing.Point(748, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "State:";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.PaleTurquoise;
            this.state.Location = new System.Drawing.Point(805, 69);
            this.state.Margin = new System.Windows.Forms.Padding(4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(67, 22);
            this.state.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label11.Location = new System.Drawing.Point(717, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cell";
            // 
            // cell
            // 
            this.cell.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cell.Location = new System.Drawing.Point(774, 191);
            this.cell.Margin = new System.Windows.Forms.Padding(4);
            this.cell.Name = "cell";
            this.cell.Size = new System.Drawing.Size(67, 22);
            this.cell.TabIndex = 34;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(732, 241);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 47);
            this.clear.TabIndex = 35;
            this.clear.Text = "Clear textboxes";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label12.Location = new System.Drawing.Point(704, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Gender";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gender.Location = new System.Drawing.Point(774, 151);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(67, 22);
            this.gender.TabIndex = 37;
            // 
            // dellabel
            // 
            this.dellabel.Location = new System.Drawing.Point(633, 460);
            this.dellabel.Margin = new System.Windows.Forms.Padding(4);
            this.dellabel.Name = "dellabel";
            this.dellabel.Size = new System.Drawing.Size(163, 28);
            this.dellabel.TabIndex = 38;
            this.dellabel.Text = "Delete Mailing Label";
            this.dellabel.UseVisualStyleBackColor = true;
            this.dellabel.Click += new System.EventHandler(this.dellabel_Click);
            // 
            // printLabels
            // 
            this.printLabels.Location = new System.Drawing.Point(62, 460);
            this.printLabels.Margin = new System.Windows.Forms.Padding(4);
            this.printLabels.Name = "printLabels";
            this.printLabels.Size = new System.Drawing.Size(163, 28);
            this.printLabels.TabIndex = 39;
            this.printLabels.Text = "Print Mailing Labels";
            this.printLabels.UseVisualStyleBackColor = true;
            this.printLabels.Click += new System.EventHandler(this.printLabels_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // delAll
            // 
            this.delAll.Location = new System.Drawing.Point(45, 424);
            this.delAll.Margin = new System.Windows.Forms.Padding(4);
            this.delAll.Name = "delAll";
            this.delAll.Size = new System.Drawing.Size(196, 28);
            this.delAll.TabIndex = 40;
            this.delAll.Text = "Delete All Mailing Labels";
            this.delAll.UseVisualStyleBackColor = true;
            this.delAll.Click += new System.EventHandler(this.delAll_Click);
            // 
            // viewLabels
            // 
            this.viewLabels.Location = new System.Drawing.Point(327, 460);
            this.viewLabels.Margin = new System.Windows.Forms.Padding(4);
            this.viewLabels.Name = "viewLabels";
            this.viewLabels.Size = new System.Drawing.Size(196, 28);
            this.viewLabels.TabIndex = 41;
            this.viewLabels.Text = "View All Mailing Labels";
            this.viewLabels.UseVisualStyleBackColor = true;
            this.viewLabels.Click += new System.EventHandler(this.viewLabels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 517);
            this.Controls.Add(this.viewLabels);
            this.Controls.Add(this.delAll);
            this.Controls.Add(this.printLabels);
            this.Controls.Add(this.dellabel);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.cell);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelmaker);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.levelemp);
            this.Controls.Add(this.levelesl);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelged);
            this.Controls.Add(this.qualifications);
            this.Controls.Add(this.enrollment);
            this.Controls.Add(this.total_emp);
            this.Controls.Add(this.total_esl);
            this.Controls.Add(this.total_ged);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Horran Appartments Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label total_ged;
        private System.Windows.Forms.Label total_esl;
        private System.Windows.Forms.Label total_emp;
        private System.Windows.Forms.CheckedListBox enrollment;
        private System.Windows.Forms.CheckedListBox qualifications;
        private System.Windows.Forms.CheckedListBox levelged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckedListBox levelesl;
        private System.Windows.Forms.CheckedListBox levelemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button labelmaker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cell;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Button dellabel;
        private System.Windows.Forms.Button printLabels;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button delAll;
        private System.Windows.Forms.Button viewLabels;
    }
}

