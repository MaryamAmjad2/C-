using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            List<string> tokens = new List<string>(input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries));
            int tokenIndex = 0;

            if (ParseList(tokens, ref tokenIndex))
            {
                labelResult.Text = "Parsing Successfull.";
            }
            else
            {
                labelResult.Text = "Parssing Failed.";
            }
        }

        private bool ParseList(List<string> tokens, ref int tokenIndex)
        {
            return ParseItem(tokens, ref tokenIndex) && ParseRest(tokens, ref tokenIndex);
        }

        private bool ParseRest(List<string> tokens, ref int tokenIndex)
        {
            if (tokenIndex < tokens.Count && tokens[tokenIndex] == ",")
            {
                tokenIndex++;
                return ParseItem(tokens, ref tokenIndex) && ParseRest(tokens, ref tokenIndex);
            }
            return true; // ε (empty) production
        }

        private bool ParseItem(List<string> tokens, ref int tokenIndex)
        {
            if (tokenIndex < tokens.Count && (tokens[tokenIndex] == "id" || tokens[tokenIndex] == "num" || tokens[tokenIndex] == "string"))
            {
                tokenIndex++;
                return true;
            }
            return false;
        }

        private void buttonValidate_Click_1(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            List<string> tokens = new List<string>(input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries));
            int tokenIndex = 0;

            if (ParseList(tokens, ref tokenIndex))
            {
                labelResult.Text = "Parsing Successful.";
            }
            else
            {
                labelResult.Text = "Parsing Failed.";
            }
        }
    }
}
 