using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDeserializingJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event
        private void buttonDeserialised_Click(object sender, EventArgs e)
        {
            //debugOutput(textBoxInput.Text);
            deserialiseJSON(textBoxInput.Text);

        }

        private void buttonClearDebug_Click(object sender, EventArgs e)
        {
            textBoxDebugOutput.Text = string.Empty;
        }

        #endregion

        #region JSON Function

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                // TO DO: Our deserialize code
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);

                debugOutput("Here's our JSON object: " + jPerson.ToString());
                debugOutput("Here's the First Name: " + jPerson.firstname);
                debugOutput("Here's the Last Name: " + jPerson.lastname);
                debugOutput("Here's the Age: " + jPerson.age);
                //debugOutput("Here's the First Name: " + jPerson.isAlive);
                //debugOutput("Here's the First Name: " + jPerson.address);
                debugOutput("Here's the streest address: " + jPerson.address.streetAddress);

                debugOutput("Attempting to print phone number....");
                foreach (var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }

            }
            catch (Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBoxDebugOutput.Text = textBoxDebugOutput.Text + strDebugText + Environment.NewLine;
                textBoxDebugOutput.SelectionStart = textBoxDebugOutput.TextLength;
                textBoxDebugOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion

        

    }
}
