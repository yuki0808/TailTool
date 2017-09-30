namespace WindowsFormsApplication1
{
  partial class Setteings
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setteings));
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.letterColour_B = new System.Windows.Forms.Button();
      this.bgColour_B = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "文字色：";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "背景色：";
      // 
      // button3
      // 
      this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button3.Location = new System.Drawing.Point(12, 112);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(53, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "OK";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button4.Location = new System.Drawing.Point(146, 112);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(53, 23);
      this.button4.TabIndex = 2;
      this.button4.Text = "Cancel";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // letterColour_B
      // 
      this.letterColour_B.BackColor = System.Drawing.SystemColors.WindowText;
      this.letterColour_B.Location = new System.Drawing.Point(83, 12);
      this.letterColour_B.Name = "letterColour_B";
      this.letterColour_B.Size = new System.Drawing.Size(107, 23);
      this.letterColour_B.TabIndex = 3;
      this.letterColour_B.UseVisualStyleBackColor = false;
      this.letterColour_B.Click += new System.EventHandler(this.button1_Click);
      // 
      // bgColour_B
      // 
      this.bgColour_B.BackColor = System.Drawing.SystemColors.Window;
      this.bgColour_B.Location = new System.Drawing.Point(83, 41);
      this.bgColour_B.Name = "bgColour_B";
      this.bgColour_B.Size = new System.Drawing.Size(107, 23);
      this.bgColour_B.TabIndex = 3;
      this.bgColour_B.UseVisualStyleBackColor = false;
      this.bgColour_B.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(83, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(107, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "デフォルト色";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 12);
      this.label3.TabIndex = 0;
      this.label3.Text = "デフォルト：";
      // 
      // Setteings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(211, 145);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.bgColour_B);
      this.Controls.Add(this.letterColour_B);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Setteings";
      this.Text = "Tail!!! -設定-";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button letterColour_B;
    private System.Windows.Forms.Button bgColour_B;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
  }
}