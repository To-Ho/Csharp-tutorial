
namespace WindowsFormsApp_Tutorial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.listCity = new System.Windows.Forms.ListBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.chbHappy = new System.Windows.Forms.CheckBox();
            this.chbSad = new System.Windows.Forms.CheckBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbSad);
            this.groupBox1.Controls.Add(this.chbHappy);
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(7, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.ItemHeight = 16;
            this.listCity.Items.AddRange(new object[] {
            "Calgary",
            "Edmonton",
            "Vancouver"});
            this.listCity.Location = new System.Drawing.Point(403, 58);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(212, 148);
            this.listCity.TabIndex = 2;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(13, 161);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 21);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(111, 161);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 21);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // chbHappy
            // 
            this.chbHappy.AutoSize = true;
            this.chbHappy.Location = new System.Drawing.Point(13, 188);
            this.chbHappy.Name = "chbHappy";
            this.chbHappy.Size = new System.Drawing.Size(71, 21);
            this.chbHappy.TabIndex = 6;
            this.chbHappy.Text = "Happy";
            this.chbHappy.UseVisualStyleBackColor = true;
            // 
            // chbSad
            // 
            this.chbSad.AutoSize = true;
            this.chbSad.Location = new System.Drawing.Point(111, 189);
            this.chbSad.Name = "chbSad";
            this.chbSad.Size = new System.Drawing.Size(55, 21);
            this.chbSad.TabIndex = 7;
            this.chbSad.Text = "Sad";
            this.chbSad.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(98, 270);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(173, 23);
            this.bSubmit.TabIndex = 3;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbSad;
        private System.Windows.Forms.CheckBox chbHappy;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.Button bSubmit;
    }
}

