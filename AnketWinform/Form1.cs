namespace AnketWinform
{
    public partial class Form1 : Form
    {

        public string _name { get; set; }
        public string _surname { get; set; }
        public string _father { get; set; }
        public string _country { get; set; }
        public string _city { get; set; }
        public string _phone { get; set; }
        public string _cins { get; set; }
        public string _searchuser { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            _name = nametext.Text;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            _surname = surnametext.Text;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            _father = fathertext.Text;
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            _country = countrytext.Text;
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            _city = citytext.Text;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            _phone = phonetext.Text;
        }

        private void buttonkisi_CheckedChanged(object sender, EventArgs e)
        {
            _cins = "Kisi";
        }

        private void buttonqadin_CheckedChanged(object sender, EventArgs e)
        {
            _cins = "Qadin";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(_father)
                && !string.IsNullOrEmpty(_country) && !string.IsNullOrEmpty(_city) && !string.IsNullOrEmpty(_phone)
                && !string.IsNullOrEmpty(_cins))
            {
                Person p = new Person(_name, _surname, _father, _country, _city, _phone, _cins);
                nametext.Text = "";
                surnametext.Text = "";
                fathertext.Text = "";
                countrytext.Text = "";
                citytext.Text = "";
                phonetext.Text = "";
                buttonkisi.Checked = false;
                buttonqadin.Checked = false;
                MessageBox.Show("Add Succesfully!");
                error.Visible = false;
            }
            else
            {
                error.Visible = true;
                error.Text = "Please Fill All Sections!";
            }
        }

        private void userload_TextChanged(object sender, EventArgs e)
        {
            _searchuser = userload.Text;
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_searchuser))
            {
                Person p = Person.Search(_searchuser);
                if (p != null)
                {
                    nametext.Text = p.Ad;
                    surnametext.Text = p.Soyad;
                    fathertext.Text = p.Ataadi;
                    countrytext.Text = p.Olke;
                    citytext.Text = p.Sheher;
                    phonetext.Text = p.Telefon;

                    if (p.Cins == "Kisi")
                    {
                        buttonkisi.Checked = true;
                    }
                    else if (p.Cins == "Qadin")
                    {
                        buttonqadin.Checked = true;
                    }
                    else
                    {

                    }
                }
                else
                {

                    MessageBox.Show("Person not found!");
                }
            }
            else
            {

                MessageBox.Show("Please enter a search user!");
            }
        }
    }
}