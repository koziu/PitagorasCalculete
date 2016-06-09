using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PitagorasCalculate
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CalculateCSide()
    {
      var a = (double)numericUpDown1.Value;
      var b = (double)numericUpDown2.Value;
      var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

      numericUpDown3.Value = (decimal) c;

      label1.Text = $"a = {a.ToString("####.##")}";
      label3.Text = $"b = {b.ToString("####.##")}";
      label2.Text = $"c = {numericUpDown3.Value.ToString("####.##")}";
    }

    private void CalculateBSide()
    {
      var a = (double)numericUpDown1.Value;
      var c = (double)numericUpDown3.Value;
      var b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

      if (b < 1)
      {
        numericUpDown2.Value = (decimal) 2;
        label3.Text = $"b = NIEPOPRAWNA WARTOŚĆ";
      }
      else
      {
        numericUpDown2.Value = (decimal)b;
        label1.Text = $"a = {a.ToString("####.##")}";
        label3.Text = $"b = {numericUpDown2.Value.ToString("####.##")}";
        label2.Text = $"c = {c.ToString("####.##")}";
      }

     
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      CalculateCSide();

      var l = e.Graphics;
      Pen pen = new Pen(Color.Black, 5);
      Point[] pointTab = {new Point(25, 5), new Point(25, 200), new Point(300, 200)};
      l.DrawPolygon(pen, pointTab);
      l.Dispose();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      CalculateCSide();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      CalculateCSide();
    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {
      
    }

    private void numericUpDown3_MouseDown(object sender, MouseEventArgs e)
    {
      CalculateBSide();
    }

    private void numericUpDown3_KeyUp(object sender, KeyEventArgs e)
    {
      CalculateBSide();
    }
  
  }
}