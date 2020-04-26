using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_task_os
{
    public partial class form_tasks : Form
    {
        public form_tasks()
        {
            InitializeComponent();
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            text_N.Text = "30";
            text_k.Text = "250";
            text_m.Text = "211";
            text_b.Text = "403";
            text_l.Text = "93";
            text_v.Text = "21";
            text_d.Text = "56";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_N.Clear();
            text_k.Clear();
            text_m.Clear();
            text_b.Clear();
            text_l.Clear();
            text_v.Clear();
            text_d.Clear();
            list_tasks.Items.Clear();
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            list_tasks.Items.Clear();
            machine m = new machine(list_tasks, Convert.ToInt32(text_N.Text),
                Convert.ToInt32(text_k.Text),
                Convert.ToInt32(text_m.Text),
                Convert.ToInt32(text_b.Text),
                Convert.ToInt32(text_l.Text),
                Convert.ToInt32(text_v.Text),
                Convert.ToInt32(text_d.Text));
            
            m.exec();
            list_tasks = m.list_tasks;
        }
    }
}
