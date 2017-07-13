using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searchDojo
{
    public partial class Form1 : Form
    {
        Regex pattern;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string[] text = txtInput.Text.Split(' ');
            pattern = null;
            pattern = new Regex(txtPattern.Text);
            foreach(string word in text)
            {
                if(pattern.IsMatch(word))
                {
                    Console.WriteLine(word);
                    txtOutput.Text += word+ "\n";
                }
            }
             
        }
    }
}
