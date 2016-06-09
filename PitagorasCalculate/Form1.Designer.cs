namespace PitagorasCalculate
{
  partial class Form1
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
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lA = new System.Windows.Forms.Label();
      this.lB = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lC = new System.Windows.Forms.Label();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.DecimalPlaces = 2;
      this.numericUpDown1.Location = new System.Drawing.Point(40, 29);
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
      this.numericUpDown1.TabIndex = 0;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.DecimalPlaces = 2;
      this.numericUpDown2.Location = new System.Drawing.Point(40, 70);
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(63, 20);
      this.numericUpDown2.TabIndex = 1;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(134, 29);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(363, 282);
      this.panel1.TabIndex = 2;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // lA
      // 
      this.lA.AutoSize = true;
      this.lA.Location = new System.Drawing.Point(12, 29);
      this.lA.Name = "lA";
      this.lA.Size = new System.Drawing.Size(13, 13);
      this.lA.TabIndex = 3;
      this.lA.Text = "a";
      // 
      // lB
      // 
      this.lB.AutoSize = true;
      this.lB.Location = new System.Drawing.Point(12, 72);
      this.lB.Name = "lB";
      this.lB.Size = new System.Drawing.Size(13, 13);
      this.lB.TabIndex = 4;
      this.lB.Text = "b";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 118);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "a = ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(165, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(25, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "c = ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(124, 217);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "b = ";
      // 
      // lC
      // 
      this.lC.AutoSize = true;
      this.lC.Location = new System.Drawing.Point(12, 115);
      this.lC.Name = "lC";
      this.lC.Size = new System.Drawing.Size(13, 13);
      this.lC.TabIndex = 5;
      this.lC.Text = "c";
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.DecimalPlaces = 2;
      this.numericUpDown3.Location = new System.Drawing.Point(40, 113);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(63, 20);
      this.numericUpDown3.TabIndex = 6;
      this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
      this.numericUpDown3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown3_KeyUp);
      this.numericUpDown3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown3_MouseDown);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 421);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.lC);
      this.Controls.Add(this.lB);
      this.Controls.Add(this.lA);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lA;
    private System.Windows.Forms.Label lB;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lC;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
  }
}

