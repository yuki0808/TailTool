namespace WindowsFormsApplication1
{
  partial class Form1
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.file_TB = new System.Windows.Forms.TextBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.start_B = new System.Windows.Forms.Button();
      this.stop_B = new System.Windows.Forms.Button();
      this.clear_B = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.button1 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "shift_jis",
            "UTF-8",
            "euc-jp"});
      this.comboBox1.Location = new System.Drawing.Point(12, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 20);
      this.comboBox1.TabIndex = 0;
      // 
      // file_TB
      // 
      this.file_TB.AllowDrop = true;
      this.file_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.file_TB.Location = new System.Drawing.Point(141, 12);
      this.file_TB.Name = "file_TB";
      this.file_TB.Size = new System.Drawing.Size(357, 19);
      this.file_TB.TabIndex = 1;
      this.file_TB.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
      this.file_TB.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
      this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
      this.richTextBox1.Location = new System.Drawing.Point(12, 68);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(519, 411);
      this.richTextBox1.TabIndex = 2;
      this.richTextBox1.Text = "";
      this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
      this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
      this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
      this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // start_B
      // 
      this.start_B.Location = new System.Drawing.Point(140, 39);
      this.start_B.Name = "start_B";
      this.start_B.Size = new System.Drawing.Size(75, 23);
      this.start_B.TabIndex = 3;
      this.start_B.Text = "Tail!!!";
      this.start_B.UseVisualStyleBackColor = true;
      this.start_B.Click += new System.EventHandler(this.start_B_Click);
      // 
      // stop_B
      // 
      this.stop_B.Enabled = false;
      this.stop_B.Location = new System.Drawing.Point(221, 39);
      this.stop_B.Name = "stop_B";
      this.stop_B.Size = new System.Drawing.Size(75, 23);
      this.stop_B.TabIndex = 3;
      this.stop_B.Text = "Stop";
      this.stop_B.UseVisualStyleBackColor = true;
      this.stop_B.Click += new System.EventHandler(this.stop_B_Click);
      // 
      // clear_B
      // 
      this.clear_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.clear_B.Location = new System.Drawing.Point(429, 39);
      this.clear_B.Name = "clear_B";
      this.clear_B.Size = new System.Drawing.Size(68, 23);
      this.clear_B.TabIndex = 3;
      this.clear_B.Text = "Clear";
      this.clear_B.UseVisualStyleBackColor = true;
      this.clear_B.Click += new System.EventHandler(this.clear_B_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(12, 43);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(97, 16);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Always on top";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 481);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(543, 23);
      this.statusStrip1.TabIndex = 6;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 18);
      this.toolStripStatusLabel1.Text = "STOPEED";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
      this.button1.Location = new System.Drawing.Point(504, 9);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(27, 24);
      this.button1.TabIndex = 7;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button3
      // 
      this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
      this.button3.Location = new System.Drawing.Point(503, 39);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(27, 23);
      this.button3.TabIndex = 8;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(543, 504);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.clear_B);
      this.Controls.Add(this.stop_B);
      this.Controls.Add(this.start_B);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.file_TB);
      this.Controls.Add(this.comboBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Tail!!!";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.contextMenuStrip1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox file_TB;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button start_B;
    private System.Windows.Forms.Button stop_B;
    private System.Windows.Forms.Button clear_B;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
  }
}

