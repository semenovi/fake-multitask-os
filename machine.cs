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
		public int[] cpu_t, hdd_t, net_t;
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
			cpu_t = new int[N];
			hdd_t = new int[N];
			net_t = new int[N];
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
		public void generate()
		{
			Random rnd = new Random();
			for (int i = 0; i < N; i++)
			{
				cpu_t[i] = rnd.Next(k - l, k + l);
				hdd_t[i] = rnd.Next(m - v, m + v);
				net_t[i] = rnd.Next(b - d, b + d);
				add_time(0, cpu_t[i], hdd_t[i], net_t[i]);
			}
		}
		public void sort()
		{
			// sort
			for (int i = 1; i < N; i++)
			{
				for (int j = i; j > 0 && cpu_t[j - 1] < cpu_t[j]; j--)
				{
					int t = cpu_t[j];
					cpu_t[j] = cpu_t[j - 1];
					cpu_t[j - 1] = t;
					t = hdd_t[j];
					hdd_t[j] = hdd_t[j - 1];
					hdd_t[j - 1] = t;
					t = net_t[j];
					net_t[j] = net_t[j - 1];
					net_t[j - 1] = t;
				}
			}
			for (int i = 0; i < N; i++)
				add_time(0, cpu_t[i], hdd_t[i], net_t[i]);
		}
		public void exec()
		{

			// cpu
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				time += cpu_t[i - 1];
				add_time(time, i, 0, 0);
			}

			// hdd
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				int idx_first = 0, idx_last = 0;
				while (idx_first < list_tasks.Items.Count - 1 && Convert.ToInt32(list_tasks.Items[idx_first].SubItems[1].Text) < i + 1)
				{
					idx_first++;
				}
				time = Convert.ToInt32(list_tasks.Items[idx_first].Text) + hdd_t[i - 1];
				idx_last = idx_first;
				while (idx_last < list_tasks.Items.Count - 1 && Convert.ToInt32(list_tasks.Items[idx_last + 1].Text) < time)
				{
					idx_last++;
				}
				if (idx_last == list_tasks.Items.Count - 1)
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 2, i);
					}
					if (Convert.ToInt32(list_tasks.Items[idx_last].Text) != time)
					{
						insert_after_idx(idx_last, time, 0, i, 0);
					}
				}
				else if (Convert.ToInt32(list_tasks.Items[idx_last + 1].Text) == time)
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 2, i);
					}
				}
				else
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 2, i);
					}
					insert_after_idx(idx_last, time, Convert.ToInt32(list_tasks.Items[idx_last].SubItems[1].Text), i, 0);
				}
			}

			// network
			time = 0;
			for (int i = 1; i <= N; i++)
			{
				int idx_first = 0, idx_last = 0;
				while (idx_first < list_tasks.Items.Count - 1 && Convert.ToInt32(list_tasks.Items[idx_first].SubItems[2].Text) < i + 1)
				{
					idx_first++;
				}
				time = Convert.ToInt32(list_tasks.Items[idx_first].Text) + net_t[i - 1];
				idx_last = idx_first;
				while (idx_last < list_tasks.Items.Count - 1 && Convert.ToInt32(list_tasks.Items[idx_last + 1].Text) < time)
				{
					idx_last++;
				}
				if (idx_last == list_tasks.Items.Count - 1)
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 3, i);
					}
					if (Convert.ToInt32(list_tasks.Items[idx_last].Text) != time)
					{
						insert_after_idx(idx_last, time, 0, 0, i);
					}
				}
				else if (Convert.ToInt32(list_tasks.Items[idx_last + 1].Text) == time)
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 3, i);
					}
				}
				else
				{
					for (int j = idx_first; j <= idx_last; j++)
					{
						modify_time(j, 3, i);
					}
					insert_after_idx(idx_last, time, Convert.ToInt32(list_tasks.Items[idx_last].SubItems[1].Text), Convert.ToInt32(list_tasks.Items[idx_last].SubItems[2].Text), i);
				}
			}
		}

	}
}
