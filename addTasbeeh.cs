using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_task_6
{
    public partial class addTasbeeh : Form
    {
        addName add;
        public addTasbeeh()
        {
            InitializeComponent();
        }
        public addTasbeeh(addName temp)
        {
            InitializeComponent();
            add = temp;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            this.add.Tasbeeh_name = txt_addtasbeeh.Text.ToString();
            txt_addtasbeeh.Text = "";
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
