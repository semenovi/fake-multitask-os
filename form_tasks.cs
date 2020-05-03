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
        machine m;
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
            button_sort.Enabled = false;
            button_exec.Enabled = false;
            text_exec_time.Text = "not available";
            text_longest.Text = "not available";
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            bool flag = text_N.Text == "";
            flag = flag || text_k.Text == "";
            flag = flag || text_m.Text == "";
            flag = flag || text_b.Text == "";
            flag = flag || text_l.Text == "";
            flag = flag || text_v.Text == "";
            flag = flag || text_d.Text == "";
            if (!flag)
            {
                m = new machine(list_tasks,
                    Convert.ToInt32(text_N.Text),
                    Convert.ToInt32(text_k.Text),
                    Convert.ToInt32(text_m.Text),
                    Convert.ToInt32(text_b.Text),
                    Convert.ToInt32(text_l.Text),
                    Convert.ToInt32(text_v.Text),
                    Convert.ToInt32(text_d.Text));
                list_tasks.Items.Clear();
                m.generate();
                list_tasks = m.list_tasks;
                button_sort.Enabled = true;
                button_exec.Enabled = true;
                text_exec_time.Text = "not available";
                text_longest.Text = "not available";
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            list_tasks.Items.Clear();
            m.sort();
            list_tasks = m.list_tasks;
            button_exec.Enabled = true;
            text_exec_time.Text = "not available";
            text_longest.Text = "not available";
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            list_tasks.Items.Clear();
            m.exec();
            list_tasks = m.list_tasks;
            text_exec_time.Text = list_tasks.Items[list_tasks.Items.Count - 1].Text;
            int longest_start, longest_end, longest_time = -1, longest = -1;
            for (int i = 1; i <= m.N; i++)
            {
                longest_start = 0;
                longest_end = 0;
                while (Convert.ToInt32(list_tasks.Items[longest_start].SubItems[1].Text) < i)
                {
                    longest_start++;
                }
                while (Convert.ToInt32(list_tasks.Items[longest_end].SubItems[3].Text) < i)
                {
                    longest_end++;
                }
                if (longest_time < Convert.ToInt32(list_tasks.Items[longest_end].Text) - Convert.ToInt32(list_tasks.Items[longest_start].Text))
                {
                    longest_time = Convert.ToInt32(list_tasks.Items[longest_end].Text) - Convert.ToInt32(list_tasks.Items[longest_start].Text);
                    longest = i;
                }
            }
            text_longest.Text = Convert.ToString(longest_time) + " (" + Convert.ToString(longest) + ")";
        }

        private void text_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_l_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_v_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void text_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
    }
}
