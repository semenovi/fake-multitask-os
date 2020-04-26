namespace multiple_task_os
{
    partial class form_tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_tasks = new System.Windows.Forms.ListView();
            this.column_header_t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_header_cpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_header_hdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_header_net = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_exec = new System.Windows.Forms.Button();
            this.text_k = new System.Windows.Forms.TextBox();
            this.text_m = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.text_d = new System.Windows.Forms.TextBox();
            this.text_v = new System.Windows.Forms.TextBox();
            this.text_l = new System.Windows.Forms.TextBox();
            this.label_k = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_v = new System.Windows.Forms.Label();
            this.label_l = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.text_N = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_default = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_tasks
            // 
            this.list_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_header_t,
            this.column_header_cpu,
            this.column_header_hdd,
            this.column_header_net});
            this.list_tasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_tasks.FullRowSelect = true;
            this.list_tasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_tasks.HideSelection = false;
            this.list_tasks.Location = new System.Drawing.Point(0, 98);
            this.list_tasks.Margin = new System.Windows.Forms.Padding(1);
            this.list_tasks.Name = "list_tasks";
            this.list_tasks.Size = new System.Drawing.Size(241, 244);
            this.list_tasks.TabIndex = 8;
            this.list_tasks.TileSize = new System.Drawing.Size(8, 8);
            this.list_tasks.UseCompatibleStateImageBehavior = false;
            this.list_tasks.View = System.Windows.Forms.View.Details;
            // 
            // column_header_t
            // 
            this.column_header_t.Text = " t";
            this.column_header_t.Width = 40;
            // 
            // column_header_cpu
            // 
            this.column_header_cpu.Text = "cpu";
            this.column_header_cpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column_header_hdd
            // 
            this.column_header_hdd.Text = "hdd";
            this.column_header_hdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column_header_net
            // 
            this.column_header_net.Text = "net";
            this.column_header_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_exec
            // 
            this.button_exec.Location = new System.Drawing.Point(0, 78);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(241, 23);
            this.button_exec.TabIndex = 7;
            this.button_exec.Text = "execute";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // text_k
            // 
            this.text_k.Location = new System.Drawing.Point(61, 21);
            this.text_k.Name = "text_k";
            this.text_k.Size = new System.Drawing.Size(61, 20);
            this.text_k.TabIndex = 0;
            this.text_k.Text = "250";
            this.text_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_m
            // 
            this.text_m.Location = new System.Drawing.Point(121, 21);
            this.text_m.Name = "text_m";
            this.text_m.Size = new System.Drawing.Size(60, 20);
            this.text_m.TabIndex = 1;
            this.text_m.Text = "211";
            this.text_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(180, 21);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(60, 20);
            this.text_b.TabIndex = 2;
            this.text_b.Text = "403";
            this.text_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_d
            // 
            this.text_d.Location = new System.Drawing.Point(180, 60);
            this.text_d.Name = "text_d";
            this.text_d.Size = new System.Drawing.Size(60, 20);
            this.text_d.TabIndex = 6;
            this.text_d.Text = "56";
            this.text_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_v
            // 
            this.text_v.Location = new System.Drawing.Point(121, 60);
            this.text_v.Name = "text_v";
            this.text_v.Size = new System.Drawing.Size(60, 20);
            this.text_v.TabIndex = 5;
            this.text_v.Text = "21";
            this.text_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_l
            // 
            this.text_l.Location = new System.Drawing.Point(61, 60);
            this.text_l.Name = "text_l";
            this.text_l.Size = new System.Drawing.Size(61, 20);
            this.text_l.TabIndex = 4;
            this.text_l.Text = "93";
            this.text_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_k
            // 
            this.label_k.Location = new System.Drawing.Point(61, 2);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(61, 16);
            this.label_k.TabIndex = 9;
            this.label_k.Text = "k";
            this.label_k.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_m
            // 
            this.label_m.Location = new System.Drawing.Point(120, 2);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(61, 16);
            this.label_m.TabIndex = 10;
            this.label_m.Text = "m";
            this.label_m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_b
            // 
            this.label_b.Location = new System.Drawing.Point(179, 2);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(61, 16);
            this.label_b.TabIndex = 11;
            this.label_b.Text = "b";
            this.label_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_d
            // 
            this.label_d.Location = new System.Drawing.Point(179, 44);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(61, 16);
            this.label_d.TabIndex = 14;
            this.label_d.Text = "d";
            this.label_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_v
            // 
            this.label_v.Location = new System.Drawing.Point(120, 44);
            this.label_v.Name = "label_v";
            this.label_v.Size = new System.Drawing.Size(61, 16);
            this.label_v.TabIndex = 13;
            this.label_v.Text = "v";
            this.label_v.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_l
            // 
            this.label_l.Location = new System.Drawing.Point(61, 44);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(61, 16);
            this.label_l.TabIndex = 12;
            this.label_l.Text = "l";
            this.label_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_N
            // 
            this.label_N.Location = new System.Drawing.Point(1, 44);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(61, 16);
            this.label_N.TabIndex = 16;
            this.label_N.Text = "N";
            this.label_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_N
            // 
            this.text_N.Location = new System.Drawing.Point(1, 60);
            this.text_N.Name = "text_N";
            this.text_N.Size = new System.Drawing.Size(61, 20);
            this.text_N.TabIndex = 3;
            this.text_N.Text = "30";
            this.text_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(0, 21);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(61, 20);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(0, 2);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(61, 20);
            this.button_default.TabIndex = 9;
            this.button_default.Text = "default";
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // form_tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 342);
            this.Controls.Add(this.button_default);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.text_N);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_v);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.text_d);
            this.Controls.Add(this.text_v);
            this.Controls.Add(this.text_l);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_m);
            this.Controls.Add(this.text_k);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.list_tasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_tasks";
            this.Text = "multiple task os";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_tasks;
        private System.Windows.Forms.ColumnHeader column_header_t;
        private System.Windows.Forms.ColumnHeader column_header_cpu;
        private System.Windows.Forms.ColumnHeader column_header_hdd;
        private System.Windows.Forms.ColumnHeader column_header_net;
        private System.Windows.Forms.Button button_exec;
        private System.Windows.Forms.TextBox text_k;
        private System.Windows.Forms.TextBox text_m;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.TextBox text_d;
        private System.Windows.Forms.TextBox text_v;
        private System.Windows.Forms.TextBox text_l;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_v;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox text_N;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_default;
    }
}

