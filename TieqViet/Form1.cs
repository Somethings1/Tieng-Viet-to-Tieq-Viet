using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieqViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.c-sharpcorner.com");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = this.textBox1.Text, result = "", ss = "";
            s += " ";
            while(s != "")
            {
                ss = s.Substring(0, s.IndexOf(" "));
                s = s.Substring(s.IndexOf(" ") + 1);
                if(ss.Contains("ch") || ss.Contains("Ch"))
                {
                    ss = ss.Replace("ch", "c");
                    ss = ss.Replace("Ch", "C");
                }
                else
                {
                    ss = ss.Replace("c", "k");
                    ss = ss.Replace("C", "K");
                }
                ss = ss.Replace("R", "Z");
                ss = ss.Replace("r", "z");
                ss = ss.Replace("D", "Z");
                ss = ss.Replace("d", "z");
                ss = ss.Replace("Gi", "Z");
                ss = ss.Replace("gi", "z");
                ss = ss.Replace("Tr", "C");
                ss = ss.Replace("tr", "c");
                ss = ss.Replace("Đ", "D");
                ss = ss.Replace("đ", "d");
                ss = ss.Replace("Gh", "G");
                ss = ss.Replace("gh", "g");
                ss = ss.Replace("Ph", "F");
                ss = ss.Replace("ph", "f");
                ss = ss.Replace("Q", "K");
                ss = ss.Replace("q", "k");
                ss = ss.Replace("Ngh", "Q");
                ss = ss.Replace("ngh", "q");
                ss = ss.Replace("Ng", "Q");
                ss = ss.Replace("ng", "q");
                ss = ss.Replace("Kh", "X");
                ss = ss.Replace("kh", "x");
                ss = ss.Replace("Th", "w");
                ss = ss.Replace("th", "w");
                ss = ss.Replace("Nh", "N'");
                ss = ss.Replace("nh", "n'");
                result += ss + " ";
            }
            this.textBox2.Text = result;
        }
    }
}
