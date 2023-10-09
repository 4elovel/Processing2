using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            Hashtable openWith = new Hashtable
            {
                { "Notepad", "notepad.exe" },
                { "Paint", "mspaint.exe" },
                { "Calculator", "calc.exe" },
                { "WordPad", "wordpad.exe" }
            };
            string text = listBox2.Text;
            string path = (string)openWith[text];
            process.StartInfo = new ProcessStartInfo(path);
            process.Start();
            listBox1.Items.Add(text);
            listBox2.Items.Remove(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string text = listBox1.Text;
            Hashtable openWith = new Hashtable
            {
                { "Notepad", "notepad" },
                { "Paint", "mspaint" },
                { "Calculator", "CalculatorApp" },
                { "WordPad", "wordpad" }
            };
            string path = (string)openWith[text];
            Process[] processes = Process.GetProcessesByName(path);
            foreach (Process i in processes)
            {
                i.Kill();

            }
            listBox2.Items.Add(text);
            listBox1.Items.Remove(text);

        }
    }
}
