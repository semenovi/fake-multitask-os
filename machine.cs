using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_task_os
{
	class machine
	{
		public int N, k, m, b, l, v, d, time;
		public ListView list_tasks;
		public machine(ListView _list_tasks, int _N, int _k, int _m, int _b, int _l, int _v, int _d)
		{
			N = _N;
			k = _k;
			m = _m;
			b = _b;
			l = _l;
			v = _v;
			d = _d;
			list_tasks = _list_tasks;
			time = 0;
		}
		public void add_time(int _t, int _cpu, int _hdd, int _net)
		{
			ListViewItem item = new ListViewItem(Convert.ToString(_t), 0);
			item.SubItems.Add(Convert.ToString(_cpu));
			item.SubItems.Add(Convert.ToString(_hdd));
			item.SubItems.Add(Convert.ToString(_net));
			list_tasks.Items.Add(item);
		}
		public void insert_after_idx(int i, int _t, int _cpu, int _hdd, int _net)
		{
			ListViewItem item = new ListViewItem(Convert.ToString(_t), 0);
			item.SubItems.Add(Convert.ToString(_cpu));
			item.SubItems.Add(Convert.ToString(_hdd));
			item.SubItems.Add(Convert.ToString(_net));
			list_tasks.Items.Insert(i + 1, item);
		}
		public void modify_time(int _idx, int _i, int _value)
		{
			list_tasks.Items[_idx].SubItems[_i].Text = Convert.ToString(_value);
		}
		public void exec()
		{
			Random rnd = new Random();

			// cpu
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				time += rnd.Next(k - l, k + l);
				add_time(time, i, 0, 0);
			}

			// hdd
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				time += rnd.Next(k - l, k + l);
				int j = 0;
				while (Convert.ToInt32(list_tasks.Items[j].SubItems[1].Text) < i)
				{
					j++;
				}
				if (Convert.ToInt32(list_tasks.Items[j].Text) < time && j != list_tasks.Items.Count - 1)
				{
					insert_after_idx(j, time,
						Convert.ToInt32(list_tasks.Items[j].SubItems[1].Text),
						i,
						0);
				}
				else if (j == list_tasks.Items.Count - 1)
				{
					add_time(time, 0, i, 0);
				}
				else
				{
					modify_time(j + 1, 2, i);
				}
			}

			// network
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				time += rnd.Next(k - l, k + l);
				int j = 0;
				while (Convert.ToInt32(list_tasks.Items[j].SubItems[2].Text) < i)
				{
					j++;
				}
				if (Convert.ToInt32(list_tasks.Items[j].Text) < time && j != list_tasks.Items.Count - 1)
				{
					insert_after_idx(j, time,
						Convert.ToInt32(list_tasks.Items[j].SubItems[1].Text),
						Convert.ToInt32(list_tasks.Items[j].SubItems[2].Text),
						i);
				}
				else if (j == list_tasks.Items.Count - 1)
				{
					add_time(time, 0, 0, i);
				}
				else
				{
					modify_time(j + 1, 3, i);
				}
			}			
		}

	}
}
