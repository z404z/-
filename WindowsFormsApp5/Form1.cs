using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            FormArray formlist = new FormArray(textBox1.Text);
            ClassQueue count = new ClassQueue.CreateArray();//
            label1.Text = Convert.ToString(formlist.result);//почему конвертация не работает
            label2.Text = Convert.ToString(count.count);
            //обратиться к createarray методу класса1 с параметром textbox1.text
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
