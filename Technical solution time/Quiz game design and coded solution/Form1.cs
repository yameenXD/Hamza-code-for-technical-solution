using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game_design_and_coded_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // this is the private method for the form1 load i.e the menu 
        {
            timer1.Start(); // this starts the timer for when the program runs
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myform = new General_knowledge_question();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myform = new Entertainment();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myform = new History();
            myform.Show();
        }
    }
}
