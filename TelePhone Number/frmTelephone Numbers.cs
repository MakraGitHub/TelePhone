using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelePhone_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconverttoonly_Click(object sender, EventArgs e)
        {

            string alphanumeric = txtPhonenumber.Text;

            //Clear the output texbox before the output processing 
            txtnumberonly.Text = "";

            for (int i = 0; i < alphanumeric.Length; i++)
            {
                //Extract a character using the substring method 

                char currenChar = alphanumeric[i].ToString().ToUpper()[0];
                // អស់លុយចាយហើយ
                string translatedChar = GetkeyPadNumber(currenChar);

                txtnumberonly.Text += translatedChar;
                //MessageBox.Show("អស់លុយចាយហើយ");
            }


        }
        // Helper method to translate a character to a phone keypad number
        private string GetkeyPadNumber(char c)
        {
            switch (c)
            {
                case '_':
                case ',':
                case '@':
                    return "1";

                case 'A':
                case 'B':
                case 'C':
                    return "2";
                case 'D':
                case 'E':
                case 'F':
                    return "3";
                case 'G':
                case 'H':
                case 'I':
                    return "4";
                case 'J':
                case 'K':
                case 'L':
                    return "5";
                case 'M':
                case 'N':
                case 'O':
                    return "6";
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    return "7";
                case 'T':
                case 'U':
                case 'V':
                    return "8";
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    return "9";
                default:
                    return c.ToString();
                // Return the character unchanged if not on the keypad

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
