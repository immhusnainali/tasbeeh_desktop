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
    
    public partial class Form1 : Form
    {
        private addTasbeeh ab;
        addName obj1;
        int count = 0;
        int max = 0;
        bool isStart = true;
        
        public Form1()
        {
            InitializeComponent();
            obj1 = new addName();
            ab = new addTasbeeh(obj1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            max =Convert.ToInt32(numericUpDown1.Value);
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            if(count == max)
            {
                MessageBox.Show("Your Tasbeeh is Completed.");
            }
            else
            {
                count++;
                btn_count.Text = Convert.ToString(count);
                btn_count.Enabled = true;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(isStart)
            {
                btn_stop.Text = "Stop";
                btn_clearlist.Enabled = true;
                btn_stop.Enabled = true;
                btn_add.Enabled = false;
                comboBox1.Enabled = false;
                btn_count.Enabled=true;
                numericUpDown1.Enabled=false;
                isStart = false;
                
            }
            else if(count == max)
            {
                btn_stop.Text = "Start";
                btn_clearlist.Enabled=false;
                btn_stop.Enabled= true;
                btn_add.Enabled=true;
                comboBox1.Enabled=false;
                btn_count.Enabled = false;
                numericUpDown1.Enabled=true;
                isStart = true;
            }
        }

        private void btn_addmore_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled=true;
            string value = Convert.ToString(comboBox1.Items[comboBox1.SelectedIndex]);
            ListViewItem listViewItem = new ListViewItem(value);
            listViewItem.SubItems.Add(Convert.ToString(count));
            listView1.Items.Add(listViewItem);
            count = 0;
            btn_count.Text = "0";
            numericUpDown1.Value = 0;
        }

        private void btn_clearlist_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            ab.ShowDialog();
            if (!comboBox1.Items.Contains(this.obj1.Tasbeeh_name))
            {
                comboBox1.Items.Add(this.obj1.Tasbeeh_name);
            }
        }
    }
}
