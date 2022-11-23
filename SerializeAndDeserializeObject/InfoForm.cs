using System.Windows.Forms;
using System;
using SerializeAndDeserializeObject.SerializeAndDeserialize;
using SerializeAndDeserializeObject.ErrorHandling;

namespace SerializeAndDeserializeObject
{
    public partial class InfoForm : Form
    {
        private OpenFileDialog _openfile;
        private SaveFileDialog _savefile;
        public InfoForm()
        {
            _openfile = new OpenFileDialog
            {
                Title = "Open File",
                InitialDirectory = @"C:\",
                Filter = "XML Format (*.xml)|*.xml| Binary Format (*.bin)|*.bin"
            };

            _savefile = new SaveFileDialog
            {
                Title = "Save File",
                InitialDirectory = @"C:\",
                Filter = "XML Format (*.xml)|*.xml|Binary Format (*.bin)|*.bin"
            };

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

                _savefile.ShowDialog();

                switch (_savefile.FilterIndex)
                {
                    case 1:
                        FileMenager.XMLSave(_savefile.FileName, person);
                        break;

                    case 2:
                        FileMenager.BinarySave(_savefile.FileName, person);
                        break;
                }
            }

            catch (EmtyFieldException emty)
            {
                emty.EmtyField();
            }
        }

        private void OpenFile(object sender, MouseEventArgs e)
        {
            Person person = null;
            _openfile.ShowDialog();

            try
            {
                switch (_openfile.FilterIndex)
                {
                    case 1:
                        person = FileMenager.XMLOpen(_openfile.FileName);
                        break;

                    case 2:
                        person = FileMenager.BinaryOpen(_openfile.FileName);
                        break;
                }

                FirstNameInput.Text = person.FirstName;
                LastNameInput.Text = person.LastName;
                AdressInput.Text = person.adress.LivingAdress;
                CityInput.Text = person.adress.City;
                TeenagerCheck.Checked = person.IsTeenager;
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

