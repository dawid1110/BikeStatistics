namespace Rejest_licznika_V2
{
    partial class Main_form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Adding = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Viewing = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.load_file = new System.Windows.Forms.Button();
            this.add_new_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.Adding.SuspendLayout();
            this.Viewing.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Adding);
            this.tabControl1.Controls.Add(this.Viewing);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // Adding
            // 
            this.Adding.Controls.Add(this.statusStrip1);
            this.Adding.Controls.Add(this.add_new_file);
            this.Adding.Controls.Add(this.load_file);
            this.Adding.Controls.Add(this.clear);
            this.Adding.Controls.Add(this.add);
            this.Adding.Controls.Add(this.textBox3);
            this.Adding.Controls.Add(this.textBox2);
            this.Adding.Controls.Add(this.textBox1);
            this.Adding.Controls.Add(this.label3);
            this.Adding.Controls.Add(this.label2);
            this.Adding.Controls.Add(this.label1);
            this.Adding.Location = new System.Drawing.Point(4, 22);
            this.Adding.Name = "Adding";
            this.Adding.Padding = new System.Windows.Forms.Padding(3);
            this.Adding.Size = new System.Drawing.Size(532, 306);
            this.Adding.TabIndex = 0;
            this.Adding.Text = "Dodawanie";
            this.Adding.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(319, 33);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Wyczyść okna";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(39, 200);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Dodaj wpis z licznika";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Czas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dystans:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trasa:";
            // 
            // Viewing
            // 
            this.Viewing.Controls.Add(this.refresh);
            this.Viewing.Controls.Add(this.listBox1);
            this.Viewing.Location = new System.Drawing.Point(4, 22);
            this.Viewing.Name = "Viewing";
            this.Viewing.Padding = new System.Windows.Forms.Padding(3);
            this.Viewing.Size = new System.Drawing.Size(532, 306);
            this.Viewing.TabIndex = 1;
            this.Viewing.Text = "Przeglądanie";
            this.Viewing.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.refresh.Location = new System.Drawing.Point(3, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(17, 300);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Odśwież";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(26, 3);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(503, 303);
            this.listBox1.TabIndex = 0;
            // 
            // load_file
            // 
            this.load_file.Location = new System.Drawing.Point(319, 85);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(108, 23);
            this.load_file.TabIndex = 8;
            this.load_file.Text = "Wczytaj plik";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.load_file_Click);
            // 
            // add_new_file
            // 
            this.add_new_file.Location = new System.Drawing.Point(319, 138);
            this.add_new_file.Name = "add_new_file";
            this.add_new_file.Size = new System.Drawing.Size(108, 23);
            this.add_new_file.TabIndex = 9;
            this.add_new_file.Text = "Dodaj nowy plik";
            this.add_new_file.UseVisualStyleBackColor = true;
            this.add_new_file.Click += new System.EventHandler(this.add_new_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 332);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_form";
            this.Text = "Rejestr licznika V2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_form_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Adding.ResumeLayout(false);
            this.Adding.PerformLayout();
            this.Viewing.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Adding;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Viewing;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add_new_file;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

