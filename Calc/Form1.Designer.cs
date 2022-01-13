
namespace Calc
{
    partial class Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupCalc = new System.Windows.Forms.GroupBox();
            this.ButSign = new System.Windows.Forms.Button();
            this.FirstNum = new System.Windows.Forms.Label();
            this.ButDelete = new System.Windows.Forms.Button();
            this.ButMultiply = new System.Windows.Forms.Button();
            this.ButDivision = new System.Windows.Forms.Button();
            this.ButClear = new System.Windows.Forms.Button();
            this.ButEqually = new System.Windows.Forms.Button();
            this.ButDot = new System.Windows.Forms.Button();
            this.But0 = new System.Windows.Forms.Button();
            this.But3 = new System.Windows.Forms.Button();
            this.But2 = new System.Windows.Forms.Button();
            this.But1 = new System.Windows.Forms.Button();
            this.ButAddition = new System.Windows.Forms.Button();
            this.But6 = new System.Windows.Forms.Button();
            this.But5 = new System.Windows.Forms.Button();
            this.But4 = new System.Windows.Forms.Button();
            this.ButSubtraction = new System.Windows.Forms.Button();
            this.But9 = new System.Windows.Forms.Button();
            this.But8 = new System.Windows.Forms.Button();
            this.But7 = new System.Windows.Forms.Button();
            this.CalcIO = new System.Windows.Forms.TextBox();
            this.GroupCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupCalc
            // 
            this.GroupCalc.Controls.Add(this.ButSign);
            this.GroupCalc.Controls.Add(this.FirstNum);
            this.GroupCalc.Controls.Add(this.ButDelete);
            this.GroupCalc.Controls.Add(this.ButMultiply);
            this.GroupCalc.Controls.Add(this.ButDivision);
            this.GroupCalc.Controls.Add(this.ButClear);
            this.GroupCalc.Controls.Add(this.ButEqually);
            this.GroupCalc.Controls.Add(this.ButDot);
            this.GroupCalc.Controls.Add(this.But0);
            this.GroupCalc.Controls.Add(this.But3);
            this.GroupCalc.Controls.Add(this.But2);
            this.GroupCalc.Controls.Add(this.But1);
            this.GroupCalc.Controls.Add(this.ButAddition);
            this.GroupCalc.Controls.Add(this.But6);
            this.GroupCalc.Controls.Add(this.But5);
            this.GroupCalc.Controls.Add(this.But4);
            this.GroupCalc.Controls.Add(this.ButSubtraction);
            this.GroupCalc.Controls.Add(this.But9);
            this.GroupCalc.Controls.Add(this.But8);
            this.GroupCalc.Controls.Add(this.But7);
            this.GroupCalc.Controls.Add(this.CalcIO);
            this.GroupCalc.Location = new System.Drawing.Point(0, 0);
            this.GroupCalc.Name = "GroupCalc";
            this.GroupCalc.Size = new System.Drawing.Size(330, 360);
            this.GroupCalc.TabIndex = 0;
            this.GroupCalc.TabStop = false;
            // 
            // ButSign
            // 
            this.ButSign.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButSign.Location = new System.Drawing.Point(7, 295);
            this.ButSign.Name = "ButSign";
            this.ButSign.Size = new System.Drawing.Size(75, 50);
            this.ButSign.TabIndex = 22;
            this.ButSign.Text = "+/-";
            this.ButSign.UseVisualStyleBackColor = true;
            this.ButSign.Click += new System.EventHandler(this.ButSign_Click);
            // 
            // FirstNum
            // 
            this.FirstNum.AutoSize = true;
            this.FirstNum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstNum.Location = new System.Drawing.Point(7, 23);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(13, 13);
            this.FirstNum.TabIndex = 21;
            this.FirstNum.Text = "0";
            // 
            // ButDelete
            // 
            this.ButDelete.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButDelete.Location = new System.Drawing.Point(249, 71);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(75, 50);
            this.ButDelete.TabIndex = 20;
            this.ButDelete.Text = "<-";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // ButMultiply
            // 
            this.ButMultiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButMultiply.Location = new System.Drawing.Point(168, 71);
            this.ButMultiply.Name = "ButMultiply";
            this.ButMultiply.Size = new System.Drawing.Size(75, 50);
            this.ButMultiply.TabIndex = 19;
            this.ButMultiply.Text = "*";
            this.ButMultiply.UseVisualStyleBackColor = true;
            this.ButMultiply.Click += new System.EventHandler(this.ButMultiply_Click);
            // 
            // ButDivision
            // 
            this.ButDivision.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButDivision.Location = new System.Drawing.Point(87, 71);
            this.ButDivision.Name = "ButDivision";
            this.ButDivision.Size = new System.Drawing.Size(75, 50);
            this.ButDivision.TabIndex = 18;
            this.ButDivision.Text = "/";
            this.ButDivision.UseVisualStyleBackColor = true;
            this.ButDivision.Click += new System.EventHandler(this.ButDivision_Click);
            // 
            // ButClear
            // 
            this.ButClear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButClear.Location = new System.Drawing.Point(6, 71);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(75, 50);
            this.ButClear.TabIndex = 17;
            this.ButClear.Text = "C";
            this.ButClear.UseVisualStyleBackColor = true;
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // ButEqually
            // 
            this.ButEqually.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButEqually.Location = new System.Drawing.Point(249, 239);
            this.ButEqually.Name = "ButEqually";
            this.ButEqually.Size = new System.Drawing.Size(75, 106);
            this.ButEqually.TabIndex = 16;
            this.ButEqually.Text = "=";
            this.ButEqually.UseVisualStyleBackColor = true;
            this.ButEqually.Click += new System.EventHandler(this.ButEqually_Click);
            // 
            // ButDot
            // 
            this.ButDot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButDot.Location = new System.Drawing.Point(168, 295);
            this.ButDot.Name = "ButDot";
            this.ButDot.Size = new System.Drawing.Size(75, 50);
            this.ButDot.TabIndex = 15;
            this.ButDot.Text = ",";
            this.ButDot.UseVisualStyleBackColor = true;
            this.ButDot.Click += new System.EventHandler(this.ButDot_Click);
            // 
            // But0
            // 
            this.But0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But0.Location = new System.Drawing.Point(87, 295);
            this.But0.Name = "But0";
            this.But0.Size = new System.Drawing.Size(75, 50);
            this.But0.TabIndex = 14;
            this.But0.Text = "0";
            this.But0.UseVisualStyleBackColor = true;
            this.But0.Click += new System.EventHandler(this.But0_Click);
            // 
            // But3
            // 
            this.But3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But3.Location = new System.Drawing.Point(168, 239);
            this.But3.Name = "But3";
            this.But3.Size = new System.Drawing.Size(75, 50);
            this.But3.TabIndex = 11;
            this.But3.Text = "3";
            this.But3.UseVisualStyleBackColor = true;
            this.But3.Click += new System.EventHandler(this.But3_Click);
            // 
            // But2
            // 
            this.But2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But2.Location = new System.Drawing.Point(87, 239);
            this.But2.Name = "But2";
            this.But2.Size = new System.Drawing.Size(75, 50);
            this.But2.TabIndex = 10;
            this.But2.Text = "2";
            this.But2.UseVisualStyleBackColor = true;
            this.But2.Click += new System.EventHandler(this.But2_Click);
            // 
            // But1
            // 
            this.But1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But1.Location = new System.Drawing.Point(6, 239);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(75, 50);
            this.But1.TabIndex = 9;
            this.But1.Text = "1";
            this.But1.UseVisualStyleBackColor = true;
            this.But1.Click += new System.EventHandler(this.But1_Click);
            // 
            // ButAddition
            // 
            this.ButAddition.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButAddition.Location = new System.Drawing.Point(249, 183);
            this.ButAddition.Name = "ButAddition";
            this.ButAddition.Size = new System.Drawing.Size(75, 50);
            this.ButAddition.TabIndex = 8;
            this.ButAddition.Text = "+";
            this.ButAddition.UseVisualStyleBackColor = true;
            this.ButAddition.Click += new System.EventHandler(this.ButAddition_Click);
            // 
            // But6
            // 
            this.But6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But6.Location = new System.Drawing.Point(168, 183);
            this.But6.Name = "But6";
            this.But6.Size = new System.Drawing.Size(75, 50);
            this.But6.TabIndex = 7;
            this.But6.Text = "6";
            this.But6.UseVisualStyleBackColor = true;
            this.But6.Click += new System.EventHandler(this.But6_Click);
            // 
            // But5
            // 
            this.But5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But5.Location = new System.Drawing.Point(87, 183);
            this.But5.Name = "But5";
            this.But5.Size = new System.Drawing.Size(75, 50);
            this.But5.TabIndex = 6;
            this.But5.Text = "5";
            this.But5.UseVisualStyleBackColor = true;
            this.But5.Click += new System.EventHandler(this.But5_Click);
            // 
            // But4
            // 
            this.But4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But4.Location = new System.Drawing.Point(6, 183);
            this.But4.Name = "But4";
            this.But4.Size = new System.Drawing.Size(75, 50);
            this.But4.TabIndex = 5;
            this.But4.Text = "4";
            this.But4.UseVisualStyleBackColor = true;
            this.But4.Click += new System.EventHandler(this.But4_Click);
            // 
            // ButSubtraction
            // 
            this.ButSubtraction.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButSubtraction.Location = new System.Drawing.Point(249, 127);
            this.ButSubtraction.Name = "ButSubtraction";
            this.ButSubtraction.Size = new System.Drawing.Size(75, 50);
            this.ButSubtraction.TabIndex = 4;
            this.ButSubtraction.Text = "-";
            this.ButSubtraction.UseVisualStyleBackColor = true;
            this.ButSubtraction.Click += new System.EventHandler(this.ButSubtraction_Click);
            // 
            // But9
            // 
            this.But9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But9.Location = new System.Drawing.Point(168, 127);
            this.But9.Name = "But9";
            this.But9.Size = new System.Drawing.Size(75, 50);
            this.But9.TabIndex = 3;
            this.But9.Text = "9";
            this.But9.UseVisualStyleBackColor = true;
            this.But9.Click += new System.EventHandler(this.But9_Click);
            // 
            // But8
            // 
            this.But8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But8.Location = new System.Drawing.Point(87, 127);
            this.But8.Name = "But8";
            this.But8.Size = new System.Drawing.Size(75, 50);
            this.But8.TabIndex = 2;
            this.But8.Text = "8";
            this.But8.UseVisualStyleBackColor = true;
            this.But8.Click += new System.EventHandler(this.But8_Click);
            // 
            // But7
            // 
            this.But7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.But7.Location = new System.Drawing.Point(6, 127);
            this.But7.Name = "But7";
            this.But7.Size = new System.Drawing.Size(75, 50);
            this.But7.TabIndex = 1;
            this.But7.Text = "7";
            this.But7.UseVisualStyleBackColor = true;
            this.But7.Click += new System.EventHandler(this.But7_Click);
            // 
            // CalcIO
            // 
            this.CalcIO.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcIO.Location = new System.Drawing.Point(6, 22);
            this.CalcIO.Name = "CalcIO";
            this.CalcIO.ReadOnly = true;
            this.CalcIO.Size = new System.Drawing.Size(318, 43);
            this.CalcIO.TabIndex = 0;
            this.CalcIO.Text = "0";
            this.CalcIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 359);
            this.Controls.Add(this.GroupCalc);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(346, 398);
            this.Name = "Calc";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_KeyDown);
            this.GroupCalc.ResumeLayout(false);
            this.GroupCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupCalc;
        private System.Windows.Forms.Button ButDelete;
        private System.Windows.Forms.Button ButMultiply;
        private System.Windows.Forms.Button ButDivision;
        private System.Windows.Forms.Button ButClear;
        private System.Windows.Forms.Button ButEqually;
        private System.Windows.Forms.Button ButDot;
        private System.Windows.Forms.Button But0;
        private System.Windows.Forms.Button But3;
        private System.Windows.Forms.Button But2;
        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.Button ButAddition;
        private System.Windows.Forms.Button But6;
        private System.Windows.Forms.Button But5;
        private System.Windows.Forms.Button But4;
        private System.Windows.Forms.Button ButSubtraction;
        private System.Windows.Forms.Button But9;
        private System.Windows.Forms.Button But8;
        private System.Windows.Forms.Button But7;
        private System.Windows.Forms.TextBox CalcIO;
        private System.Windows.Forms.Label FirstNum;
        private System.Windows.Forms.Button ButSign;
    }
}

