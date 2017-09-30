using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
  public partial class Form1 : Form
  {

    private static Boolean loopFlg = false;
    private static Boolean tailFlg = false;
    private static string fileName = "";
    private static string encoding = "";
    private static FileStream fs = null;
    private static StreamReader sr = null;
    private static Thread tr = null;
    private static Thread mtr = null;
    private RegistryKey userReg = null;
    internal static Color letterColour = Color.Black;
    internal static Color bgColour = SystemColors.Window;

    public Form1()
    {
      InitializeComponent();

      comboBox1.SelectedIndex = 0;
      this.KeyPreview = !this.KeyPreview;
      this.richTextBox1.AllowDrop = true;
      this.richTextBox1.DragEnter += new DragEventHandler(this.textBox1_DragEnter);
      this.richTextBox1.DragDrop += new DragEventHandler(this.textBox1_DragDrop);
    }


    /// <summary>
    /// threadでloop
    /// </summary>
    private void DoTail()
    {
      loopFlg = true;

      long numOfLines = 1000;

      string line = "";
      StringBuilder sb = new StringBuilder();
      long pos = fs.Length;

      if (pos > numOfLines)
      {
        fs.Seek(-numOfLines, SeekOrigin.End);
      }

      if ((line = sr.ReadLine()) != null)
      {
        sb.Append(line);
        while ((line = sr.ReadLine()) != null)
        {
          sb.Append(System.Environment.NewLine + line);
        }
      }

      AppendText(sb.ToString());

      //以下ループ
      while (loopFlg)
      {
        while ((line = sr.ReadLine()) != null)
        {
          AppendText(line + System.Environment.NewLine);
        }
        Thread.Sleep(100);
      }
    }

    private void textBox1_DragDrop(object sender, DragEventArgs e)
    {
      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
      string name = string.Empty;
      name = System.IO.Path.GetFullPath(files[0]);
      this.file_TB.Text = System.IO.Path.GetFullPath(files[0]); ;
    }

    private void textBox1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        e.Effect = DragDropEffects.Copy;
      }
    }

    private void start_B_Click(object sender, EventArgs e)
    {
      fileName = file_TB.Text;

      if ( fileName == "" || fileName == null ) {
        MessageBox.Show("ファイルを指定して下さい。");
        return;
      }
      else if (!File.Exists(fileName))
      {
        MessageBox.Show("ファイル名:["+ fileName + "]は存在しません。");
        return;
      }

      encoding = comboBox1.SelectedItem.ToString();

      fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
      sr = new StreamReader(fs, Encoding.GetEncoding(encoding));

      setStartTailing();

      tr = new Thread(DoTail);
      tr.Start();
    }

    private void setStartTailing()
    {
      start_B.Enabled = false;
      stop_B.Enabled = true;
      comboBox1.Enabled = false;

      mtr = new Thread(tailingStatus);
      mtr.Start();
    }

    private void tailingStatus() {
      
      tailFlg = true;
      int maxNumOfDots = 6;
      string dots = "";
      int c = 0;

      while (tailFlg)
      {
        dots = dots + ".";
        toolStripStatusLabel1.Text = "TAILING" + dots;
        c++;
        if (c == maxNumOfDots)
        {
          dots = "";
          c = 0;
        }
        Thread.Sleep(500);
      }
    }

    private void setStopTailing()
    {
      start_B.Enabled = true;
      stop_B.Enabled = false;
      comboBox1.Enabled = true;

      tailFlg = false;
      if (mtr != null)
      {
        if (!mtr.IsAlive)
        {
          mtr.Abort();
        }
      }
      toolStripStatusLabel1.Text = "STOPPED";
    }

    private void stop_B_Click(object sender, EventArgs e)
    {
      closeAll();
      setStopTailing();
    }

    private void clear_B_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = "";
    }

    public delegate void AppendTextCallback(string text);

    public void AppendText(string text)
    {
      if (this.richTextBox1.InvokeRequired)
      {
        AppendTextCallback delegateMethod = new AppendTextCallback(AppendText);
        this.Invoke(delegateMethod, new object[] { text });
      }
      else
      {
        this.richTextBox1.AppendText(text);
        this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
        this.richTextBox1.Focus();
        this.richTextBox1.ScrollToCaret();
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
       closeAll();

       tailFlg = false;
       if (mtr != null)
       {
         if (!mtr.IsAlive)
         {
           mtr.Abort();
         }
       }
    }

    private void closeAll() {
      loopFlg = false;
      if (tr != null)
      {
        if (!tr.IsAlive)
        {
          tr.Abort();
        }
      }
      if (sr != null)
      {
        sr.Close();
        sr.Dispose();
      }
      if (fs != null)
      {
        fs.Close();
        fs.Dispose();
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        this.TopMost = true;
      }
      else {
        this.TopMost = false;
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string temp = richTextBox1.SelectedText;
      Clipboard.SetText(temp);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Title = "開くファイルを選択してください";
      ofd.RestoreDirectory = true;
      ofd.CheckFileExists = true;
      ofd.CheckPathExists = true;
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        file_TB.Text = "";
        file_TB.Text = ofd.FileName;
      }
    }

    private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
    {
      //int selectPos = richTextBox1.SelectionStart;
      //int lastPos = richTextBox1.Text.Length;

      //if (e.KeyCode != Keys.Enter)
      //{
      //  e.Handled = true;
      //}
    }

    private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      //e.Handled = true;
    }

    private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      string temp = richTextBox1.SelectedText;

      if(temp.Length!=0){
        Clipboard.SetText(temp);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {

        userReg = Application.UserAppDataRegistry;
        userReg.SetValue("WindowState", (int)(this.WindowState));

        if (this.WindowState == FormWindowState.Normal)
        {
          userReg.SetValue("X", this.Location.X);
          userReg.SetValue("Y", this.Location.Y);
          userReg.SetValue("Height", this.Height);
          userReg.SetValue("Width", this.Width);
          userReg.SetValue("ForeColor", letterColour.R + "," +letterColour.G + "," +letterColour.B);
          userReg.SetValue("BackColor", bgColour.R + "," + bgColour.G + "," + bgColour.B);
        }

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      userReg = Application.UserAppDataRegistry;

      try
      {
        int x = (int)(userReg.GetValue("X"));
        int y = (int)(userReg.GetValue("Y"));
        this.Location = new Point(x, y);

        int height = (int)userReg.GetValue("Height");
        int width = (int)userReg.GetValue("Width");
        this.Size = new Size(width, height);

        string lcCodes = (string)userReg.GetValue("ForeColor");
        letterColour = Color.FromArgb(getColourCode(lcCodes, 1), getColourCode(lcCodes, 2), getColourCode(lcCodes, 3));

        string bgCodes = (string)userReg.GetValue("BackColor");
        bgColour = Color.FromArgb(getColourCode(bgCodes, 1), getColourCode(bgCodes, 2), getColourCode(bgCodes, 3));

        richTextBox1.ForeColor = letterColour;
        richTextBox1.BackColor = bgColour;

        this.WindowState = (FormWindowState)userReg.GetValue("WindowState");
      }
      catch
      {
        //ignore
      }


      string[] cmds = System.Environment.GetCommandLineArgs();

      if (cmds.Length >= 2)
      {
        if (cmds[1].Length != 0)
        {
          file_TB.Text = cmds[1];
        }

        if (cmds.Length >= 3)
        {
          int num = 0;
          if (cmds[2].Length != 0)
          {
            bool resultBool = Int32.TryParse(cmds[2], out num);

            if(num >=3){
              num = 0;
            }

            comboBox1.SelectedIndex = num;
          }
        }
        start_B.PerformClick();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Setteings cp = new Setteings();
      //cp.Closed += new EventHandler(Setteings_FormClosed);
      DialogResult dlgRet = cp.ShowDialog();

      if (dlgRet.ToString() == "OK")
      {
        //OK
        richTextBox1.ForeColor = letterColour;
        richTextBox1.BackColor = bgColour;
      }
      else 
      { 
      }
    }

    private void Setteings_FormClosed(object sender, EventArgs e)
    {
      Setteings f = (Setteings)sender;
    }

    private int getColourCode( string colorCodes, int num ) {

      int result = 0;
      
      if(num != 0){
        num -= 1;
      }

      string[] split = colorCodes.Split(',');

      bool resultBool = Int32.TryParse( split[num], out result);

      return result;
    }


    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F9)
      {
        HelpDialog help = new HelpDialog();
        help.ShowDialog();
      }
    }
  }
}
