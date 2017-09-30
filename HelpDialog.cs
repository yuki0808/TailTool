﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class HelpDialog : Form
  {

    private const int CLICK_MAX_NUM = 5;
    //private int countClickedNum = 0;
    private int konamiCmdCount = 0;
    private Keys[] konamiCmd = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Right, Keys.Left, Keys.Right, Keys.Left, Keys.B, Keys.A };


    public HelpDialog()
    {
      InitializeComponent();
      this.MaximizeBox = false;
      this.MinimizeBox = false;

      string appVersion = Application.ProductVersion;
      string appProductName = Application.ProductName;
      string appCompanyName = Application.CompanyName;
      Assembly mainAssembly = Assembly.GetEntryAssembly();
      string appCopyright = "-";
      object[] CopyrightArray =
        mainAssembly.GetCustomAttributes(
          typeof(AssemblyCopyrightAttribute), false);
      if ((CopyrightArray != null) && (CopyrightArray.Length > 0))
      {
        appCopyright =
          ((AssemblyCopyrightAttribute)CopyrightArray[0]).Copyright;
      }

      // 詳細情報を取得
      string appDescription = "-";
      object[] DescriptionArray =
        mainAssembly.GetCustomAttributes(
          typeof(AssemblyDescriptionAttribute), false);
      if ((DescriptionArray != null) && (DescriptionArray.Length > 0))
      {
        appDescription =
          ((AssemblyDescriptionAttribute)DescriptionArray[0]).Description;
      }

      label1.Text = appProductName + "＠" + appCompanyName;
      label2.Text = "Version " + appVersion; ;
      label3.Text = appCopyright;
    }

    private void help_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == konamiCmd[konamiCmdCount])
      {
        konamiCmdCount++;
      }
      else
      {
        konamiCmdCount = 0;
      }

      if (konamiCmdCount == konamiCmd.Length)
      {
        konamiCmdCount = 0;
        MessageBox.Show("コナミコマンドですよね?");
      }
    }
  }
}
