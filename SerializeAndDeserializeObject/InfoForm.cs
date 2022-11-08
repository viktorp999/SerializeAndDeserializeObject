using System.Windows.Forms;
using System;
using SerializeAndDeserializeObject.SerializeAndDeserialize;
using SerializeAndDeserializeObject.ErrorHandling;

namespace SerializeAndDeserializeObject
{
    public partial class InfoForm : Form
    {
        private string _binaryfilename = "PersonInfo.bin";
        private string _xmlfilename = "PersonInfo.xml";
        public InfoForm()
        {
            InitializeComponent();
        }

        private void SaveFile(object sender, MouseEventArgs e)
        {
            Person person = new Person
            {
                FirstName = FirstNameInput.Text,
                LastName = LastNameInput.Text,
                adress = new Adress
                {
                    City = CityInput.Text,
                    LivingAdress = AdressInput.Text

                },
                IsTeenager = TeenagerCheck.Checked
            };

            try
            {

                if (FirstNameInput.Text == "" || FirstNameInput.Text == " " || LastNameInput.Text == "" || LastNameInput.Text == " " || CityInput.Text == "" || CityInput.Text == " " || AdressInput.Text == "" || AdressInput.Text == " ")
                {
                    throw new EmtyFieldException();
                }

                if (BinaryCheck.Checked == true)
                {
                    FileMenager.BinarySave(_binaryfilename, person);
                }

                if (XMLCheck.Checked == true)
                {
                    FileMenager.XMLSave(_xmlfilename, person);
                }
            }
            catch(EmtyFieldException emty)
            {
                emty.EmtyField();
            }
        }

        private void OpenFile(object sender, MouseEventArgs e)
        {
            Person person = null;

            try
            {

                if (BinaryCheck.Checked == true)
                {
                    person = FileMenager.BinaryOpen(_binaryfilename);
                }

                if (XMLCheck.Checked == true)
                {
                    person = FileMenager.XMLOpen(_xmlfilename);
                }

                FirstNameInput.Text = person.FirstName;
                LastNameInput.Text = person.LastName;
                AdressInput.Text = person.adress.LivingAdress;
                CityInput.Text = person.adress.City;
                TeenagerCheck.Checked = person.IsTeenager;
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

