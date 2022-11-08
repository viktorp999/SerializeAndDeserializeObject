using System;
using System.Windows.Forms;

namespace SerializeAndDeserializeObject.ErrorHandling
{
    public class EmtyFieldException : Exception
    {
        private string _errorstring = "Fields should not be emty";
        public void EmtyField()
        {
            MessageBox.Show(_errorstring, ErrorTitle.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
