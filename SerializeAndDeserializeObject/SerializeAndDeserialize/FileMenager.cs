using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using SerializeAndDeserializeObject.ErrorHandling;
using System;

namespace SerializeAndDeserializeObject.SerializeAndDeserialize
{
    public static class FileMenager
    {
        private static string _errorstring = "File can not be found";
        private static string _errorstring2 = "Empty file path not allowed";
       
        public static void XMLSave(string filename, Person person)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Person));
                FileStream filestream = new FileStream(filename, FileMode.Create, FileAccess.Write);

                using (filestream)
                {
                    xml.Serialize(filestream, person);
                }
            }

            catch(ArgumentException)
            {
                MessageBox.Show(_errorstring2, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Person XMLOpen(string filename)
        {
            Person person = null;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Person));
                FileStream filestream = new FileStream(filename, FileMode.Open, FileAccess.Read);

                using (filestream)
                {
                    person = (Person)xml.Deserialize(filestream);
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show(_errorstring, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch(ArgumentException)
            {
                MessageBox.Show(_errorstring2, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return person;
        }

        public static void BinarySave(string filename, Person person)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream filestream = new FileStream(filename, FileMode.Create, FileAccess.Write);

                using (filestream)
                {
                    formatter.Serialize(filestream, person);
                }
            }

            catch(ArgumentException)
            {
                MessageBox.Show(_errorstring2, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Person BinaryOpen(string filename)
        {
            Person person = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream filestream = new FileStream(filename, FileMode.Open, FileAccess.Read);

                using (filestream)
                {
                    person = (Person)formatter.Deserialize(filestream);
                }
            }

            catch(FileNotFoundException)
            {
                MessageBox.Show(_errorstring, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch(ArgumentException)
            {
                MessageBox.Show(_errorstring2, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return person;
        }
    }
}

 
