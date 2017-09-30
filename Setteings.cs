using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public partial class Setteings : Form
  {

    private static Color DEFAULT_LETTER_COLOUR = Color.Black;
    private static Color DEFAULT_BG_COLOUR = SystemColors.Window;

    public Setteings()
    {
      InitializeComponent();
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      letterColour_B.BackColor = Form1.letterColour;
      bgColour_B.BackColor = Form1.bgColour;
    }

    /// <summary>
    /// letter colour
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      cd.Color = letterColour_B.BackColor;
      if (cd.ShowDialog() == DialogResult.OK)
      {
        letterColour_B.BackColor = cd.Color;
      }
    }

    /// <summary>
    /// background clolour
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button2_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      cd.Color = bgColour_B.BackColor;
      if (cd.ShowDialog() == DialogResult.OK)
      {
        bgColour_B.BackColor = cd.Color;
      }
    }

    /// <summary>
    /// ok
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button3_Click(object sender, EventArgs e)
    {
      Form1.letterColour = letterColour_B.BackColor;
      Form1.bgColour = bgColour_B.BackColor;
      this.Close();
    }

    /// <summary>
    /// cancel
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button4_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /// <summary>
    /// back to default colour
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click_1(object sender, EventArgs e)
    {
      letterColour_B.BackColor = DEFAULT_LETTER_COLOUR;
      bgColour_B.BackColor = DEFAULT_BG_COLOUR;

    }
  }
}
