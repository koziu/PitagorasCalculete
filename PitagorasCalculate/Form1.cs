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
      Calculate((double)numericUpDown1.Value, (double)numericUpDown2.Value);
    }

    private void CalculateSide(double? _a = null, double? _b = null)
    {
      if (_a != null && _b != null)
      {
        var a = (double) _a;
        var b = (double) _b;
        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        numericUpDown3.Value = (decimal) c;

        label1.Text = $"a = {a.ToString("####.##")}";
        label3.Text = $"b = {b.ToString("####.##")}";
        label2.Text = $"c = {numericUpDown3.Value.ToString("####.##")}";
      }
      else
      {
        var a = (double)numericUpDown1.Value;
        var c = (double)numericUpDown3.Value;
        var b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

        if (b < 1 || double.IsNaN(b))
        {
          b =  (double)numericUpDown2.Value;
          a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
          if ((b < 1 || double.IsNaN(b)) || (a < 1 || double.IsNaN(a)))
          {
            label1.Text = @"a = NIEPOPRAWNA WARTOŚĆ";
            label2.Text = @"c = NIEPOPRAWNA WARTOŚĆ";
            label3.Text = @"b = NIEPOPRAWNA WARTOŚĆ";
          }
          else
          {
            numericUpDown2.Value = (decimal)b;
            numericUpDown1.Value = (decimal)a;
          }
          
        }
        else
        {
          numericUpDown2.Value = (decimal)b;
          label1.Text = $"a = {a.ToString("####.##")}";
          label3.Text = $"b = {numericUpDown2.Value.ToString("####.##")}";
          label2.Text = $"c = {c.ToString("####.##")}";
        }
      }
    }
 
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      CalculateSide();

      var l = e.Graphics;
      Pen pen = new Pen(Color.Black, 5);
      Point[] pointTab = {new Point(25, 5), new Point(25, 200), new Point(300, 200)};
      l.DrawPolygon(pen, pointTab);
      l.Dispose();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      Calculate((double) numericUpDown1.Value, (double) numericUpDown2.Value);
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      Calculate((double)numericUpDown1.Value, (double)numericUpDown2.Value);
    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {
      Calculate();
    }

    private void Calculate(double? _a = null, double? _b = null)
    {
      CalculateSide(_a, _b);
      CalculateAre();
      CalculateCircuite();
      CalculateSinusAlfa();
      CalculateCosinusAlfa();
      CalculateTangesAlfa();
      CalculateCotangesAlfa();
    }

    private void CalculateAre()
    {
      lArea.Text = $"Pole: {(numericUpDown1.Value*numericUpDown2.Value/2).ToString("####.##")} cm^2";
    }

    private void CalculateCircuite()
    {
      lCircuit.Text = @"Obwód: ";
      lCircuit.Text += $"Obwód: {(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value).ToString("####.##")} cm";
    }

    private void CalculateSinusAlfa()
    {
      lsAlfa.Text = @"Sinus alfa: ";
      lsAlfa.Text += $"0{(numericUpDown1.Value/numericUpDown3.Value).ToString("#.##")}";
    }

    private void CalculateCosinusAlfa()
    {
      lcAlfa.Text = @"Cosinus alfa: ";
      lcAlfa.Text += $"0{(numericUpDown2.Value / numericUpDown3.Value).ToString("#.##")}";
    }
    private void CalculateTangesAlfa()
    {
      ltAlfa.Text = @"Tanges alfa: ";
      var result = (numericUpDown1.Value / numericUpDown2.Value);
      var resultText = result.ToString("####.##");
      result = decimal.Parse(resultText);
      if (result < 1 && result > -1)
      {
        ltAlfa.Text += $"0{(numericUpDown1.Value/numericUpDown2.Value).ToString("#.##")}";
      }
      else
      {
        ltAlfa.Text += $"{(numericUpDown1.Value / numericUpDown2.Value).ToString("#.##")}";

      }
    }
    private void CalculateCotangesAlfa()
    {
      lcoAlfa.Text = @"Cotanges alfa: ";
      var result = (numericUpDown2.Value/numericUpDown1.Value);
      var resultText = result.ToString("####.##");
      result = decimal.Parse(resultText);
      if (result < 1 && result > -1)
      {
        lcoAlfa.Text += $"0{(result).ToString("#.##")}";
      }
      else
      {
        lcoAlfa.Text += $"{(result).ToString("#.##")}";
      }
    }

  }
}