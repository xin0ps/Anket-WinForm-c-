namespace AnketWinform
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
            this.userload = new System.Windows.Forms.RichTextBox();
            this.nametext = new System.Windows.Forms.RichTextBox();
            this.surnametext = new System.Windows.Forms.RichTextBox();
            this.fathertext = new System.Windows.Forms.RichTextBox();
            this.phonetext = new System.Windows.Forms.RichTextBox();
            this.citytext = new System.Windows.Forms.RichTextBox();
            this.countrytext = new System.Windows.Forms.RichTextBox();
            this.ad = new System.Windows.Forms.Label();
            this.label2yad = new System.Windows.Forms.Label();
            this.ata = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.seher = new System.Windows.Forms.Label();
            this.olke = new System.Windows.Forms.Label();
            this.buttonkisi = new System.Windows.Forms.RadioButton();
            this.buttonqadin = new System.Windows.Forms.RadioButton();
            this.load = new System.Windows.Forms.Button();
            this.cins = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userload
            // 
            this.userload.Location = new System.Drawing.Point(63, 12);
            this.userload.Name = "userload";
            this.userload.Size = new System.Drawing.Size(134, 29);
            this.userload.TabIndex = 0;
            this.userload.Text = "";
            this.userload.TextChanged += new System.EventHandler(this.userload_TextChanged);
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(161, 82);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(160, 29);
            this.nametext.TabIndex = 1;
            this.nametext.Text = "";
            this.nametext.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // surnametext
            // 
            this.surnametext.Location = new System.Drawing.Point(161, 117);
            this.surnametext.Name = "surnametext";
            this.surnametext.Size = new System.Drawing.Size(160, 29);
            this.surnametext.TabIndex = 2;
            this.surnametext.Text = "";
            this.surnametext.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // fathertext
            // 
            this.fathertext.Location = new System.Drawing.Point(161, 152);
            this.fathertext.Name = "fathertext";
            this.fathertext.Size = new System.Drawing.Size(160, 29);
            this.fathertext.TabIndex = 3;
            this.fathertext.Text = "";
            this.fathertext.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(161, 301);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(160, 29);
            this.phonetext.TabIndex = 6;
            this.phonetext.Text = "";
            this.phonetext.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // citytext
            // 
            this.citytext.Location = new System.Drawing.Point(161, 256);
            this.citytext.Name = "citytext";
            this.citytext.Size = new System.Drawing.Size(160, 29);
            this.citytext.TabIndex = 5;
            this.citytext.Text = "";
            this.citytext.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // countrytext
            // 
            this.countrytext.Location = new System.Drawing.Point(161, 221);
            this.countrytext.Name = "countrytext";
            this.countrytext.Size = new System.Drawing.Size(160, 29);
            this.countrytext.TabIndex = 4;
            this.countrytext.Text = "";
            this.countrytext.TextChanged += new System.EventHandler(this.richTextBox7_TextChanged);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(37, 91);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(28, 20);
            this.ad.TabIndex = 7;
            this.ad.Text = "Ad";
            // 
            // label2yad
            // 
            this.label2yad.AutoSize = true;
            this.label2yad.Location = new System.Drawing.Point(37, 126);
            this.label2yad.Name = "label2yad";
            this.label2yad.Size = new System.Drawing.Size(50, 20);
            this.label2yad.TabIndex = 8;
            this.label2yad.Text = "Soyad";
            // 
            // ata
            // 
            this.ata.AutoSize = true;
            this.ata.Location = new System.Drawing.Point(37, 161);
            this.ata.Name = "ata";
            this.ata.Size = new System.Drawing.Size(57, 20);
            this.ata.TabIndex = 9;
            this.ata.Text = "Ata adi";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(37, 309);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(58, 20);
            this.telefon.TabIndex = 12;
            this.telefon.Text = "Telefon";
            // 
            // seher
            // 
            this.seher.AutoSize = true;
            this.seher.Location = new System.Drawing.Point(37, 265);
            this.seher.Name = "seher";
            this.seher.Size = new System.Drawing.Size(54, 20);
            this.seher.TabIndex = 11;
            this.seher.Text = "Sheher";
            // 
            // olke
            // 
            this.olke.AutoSize = true;
            this.olke.Location = new System.Drawing.Point(37, 230);
            this.olke.Name = "olke";
            this.olke.Size = new System.Drawing.Size(39, 20);
            this.olke.TabIndex = 10;
            this.olke.Text = "Olke";
            // 
            // buttonkisi
            // 
            this.buttonkisi.AutoSize = true;
            this.buttonkisi.Location = new System.Drawing.Point(144, 358);
            this.buttonkisi.Name = "buttonkisi";
            this.buttonkisi.Size = new System.Drawing.Size(53, 24);
            this.buttonkisi.TabIndex = 13;
            this.buttonkisi.TabStop = true;
            this.buttonkisi.Text = "Kisi";
            this.buttonkisi.UseVisualStyleBackColor = true;
            this.buttonkisi.CheckedChanged += new System.EventHandler(this.buttonkisi_CheckedChanged);
            // 
            // buttonqadin
            // 
            this.buttonqadin.AutoSize = true;
            this.buttonqadin.Location = new System.Drawing.Point(251, 358);
            this.buttonqadin.Name = "buttonqadin";
            this.buttonqadin.Size = new System.Drawing.Size(70, 24);
            this.buttonqadin.TabIndex = 14;
            this.buttonqadin.TabStop = true;
            this.buttonqadin.Text = "Qadin";
            this.buttonqadin.UseVisualStyleBackColor = true;
            this.buttonqadin.CheckedChanged += new System.EventHandler(this.buttonqadin_CheckedChanged);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(238, 11);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(94, 29);
            this.load.TabIndex = 15;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // cins
            // 
            this.cins.AutoSize = true;
            this.cins.Location = new System.Drawing.Point(37, 358);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(36, 20);
            this.cins.TabIndex = 16;
            this.cins.Text = "Cins";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(124, 426);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 33);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(37, 399);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(41, 20);
            this.error.TabIndex = 18;
            this.error.Text = "Error";
            this.error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 471);
            this.Controls.Add(this.error);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.load);
            this.Controls.Add(this.buttonqadin);
            this.Controls.Add(this.buttonkisi);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.seher);
            this.Controls.Add(this.olke);
            this.Controls.Add(this.ata);
            this.Controls.Add(this.label2yad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.citytext);
            this.Controls.Add(this.countrytext);
            this.Controls.Add(this.fathertext);
            this.Controls.Add(this.surnametext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.userload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox userload;
        private RichTextBox nametext;
        private RichTextBox surnametext;
        private RichTextBox fathertext;
        private RichTextBox phonetext;
        private RichTextBox citytext;
        private RichTextBox countrytext;
        private Label ad;
        private Label label2yad;
        private Label ata;
        private Label telefon;
        private Label seher;
        private Label olke;
        private RadioButton buttonkisi;
        private RadioButton buttonqadin;
        private Button load;
        private Label cins;
        private Button save;
        private Label error;
    }
}