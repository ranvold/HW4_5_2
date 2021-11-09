
namespace HW4_5_2
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.groupBoxFigures = new System.Windows.Forms.GroupBox();
            this.RadioButtonRhombus = new System.Windows.Forms.RadioButton();
            this.RadioButtonSquare = new System.Windows.Forms.RadioButton();
            this.RadioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.RadioButtonCircle = new System.Windows.Forms.RadioButton();
            this.RadioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.ButtonPerimeter = new System.Windows.Forms.Button();
            this.ButtonArea = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.groupBoxFigures.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 85);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(12, 169);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(12, 249);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 153);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 233);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(0, 13);
            this.Label3.TabIndex = 5;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(12, 368);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(252, 20);
            this.TextBoxResult.TabIndex = 6;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(9, 352);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(40, 13);
            this.LabelResult.TabIndex = 7;
            this.LabelResult.Text = "Result:";
            // 
            // groupBoxFigures
            // 
            this.groupBoxFigures.Controls.Add(this.RadioButtonRhombus);
            this.groupBoxFigures.Controls.Add(this.RadioButtonSquare);
            this.groupBoxFigures.Controls.Add(this.RadioButtonRectangle);
            this.groupBoxFigures.Controls.Add(this.RadioButtonCircle);
            this.groupBoxFigures.Controls.Add(this.RadioButtonTriangle);
            this.groupBoxFigures.Location = new System.Drawing.Point(380, 101);
            this.groupBoxFigures.Name = "groupBoxFigures";
            this.groupBoxFigures.Size = new System.Drawing.Size(152, 145);
            this.groupBoxFigures.TabIndex = 10;
            this.groupBoxFigures.TabStop = false;
            this.groupBoxFigures.Text = "Figure:";
            // 
            // RadioButtonRhombus
            // 
            this.RadioButtonRhombus.AutoSize = true;
            this.RadioButtonRhombus.Location = new System.Drawing.Point(7, 115);
            this.RadioButtonRhombus.Name = "RadioButtonRhombus";
            this.RadioButtonRhombus.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonRhombus.TabIndex = 4;
            this.RadioButtonRhombus.TabStop = true;
            this.RadioButtonRhombus.Text = "Rhombus";
            this.RadioButtonRhombus.UseVisualStyleBackColor = true;
            this.RadioButtonRhombus.CheckedChanged += new System.EventHandler(this.RadioButtonRhombus_CheckedChanged);
            // 
            // RadioButtonSquare
            // 
            this.RadioButtonSquare.AutoSize = true;
            this.RadioButtonSquare.Location = new System.Drawing.Point(7, 92);
            this.RadioButtonSquare.Name = "RadioButtonSquare";
            this.RadioButtonSquare.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonSquare.TabIndex = 3;
            this.RadioButtonSquare.TabStop = true;
            this.RadioButtonSquare.Text = "Square";
            this.RadioButtonSquare.UseVisualStyleBackColor = true;
            this.RadioButtonSquare.CheckedChanged += new System.EventHandler(this.RadioButtonSquare_CheckedChanged);
            // 
            // RadioButtonRectangle
            // 
            this.RadioButtonRectangle.AutoSize = true;
            this.RadioButtonRectangle.Location = new System.Drawing.Point(7, 68);
            this.RadioButtonRectangle.Name = "RadioButtonRectangle";
            this.RadioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.RadioButtonRectangle.TabIndex = 2;
            this.RadioButtonRectangle.TabStop = true;
            this.RadioButtonRectangle.Text = "Rectangle";
            this.RadioButtonRectangle.UseVisualStyleBackColor = true;
            this.RadioButtonRectangle.CheckedChanged += new System.EventHandler(this.RadioButtonRectangle_CheckedChanged);
            // 
            // RadioButtonCircle
            // 
            this.RadioButtonCircle.AutoSize = true;
            this.RadioButtonCircle.Location = new System.Drawing.Point(7, 43);
            this.RadioButtonCircle.Name = "RadioButtonCircle";
            this.RadioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.RadioButtonCircle.TabIndex = 1;
            this.RadioButtonCircle.TabStop = true;
            this.RadioButtonCircle.Text = "Circle";
            this.RadioButtonCircle.UseVisualStyleBackColor = true;
            this.RadioButtonCircle.CheckedChanged += new System.EventHandler(this.RadioButtonCircle_CheckedChanged);
            // 
            // RadioButtonTriangle
            // 
            this.RadioButtonTriangle.AutoSize = true;
            this.RadioButtonTriangle.Location = new System.Drawing.Point(7, 20);
            this.RadioButtonTriangle.Name = "RadioButtonTriangle";
            this.RadioButtonTriangle.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonTriangle.TabIndex = 0;
            this.RadioButtonTriangle.Text = "Triangle";
            this.RadioButtonTriangle.UseVisualStyleBackColor = true;
            this.RadioButtonTriangle.CheckedChanged += new System.EventHandler(this.RadioButtonTriangle_CheckedChanged);
            // 
            // ButtonPerimeter
            // 
            this.ButtonPerimeter.Location = new System.Drawing.Point(310, 368);
            this.ButtonPerimeter.Name = "ButtonPerimeter";
            this.ButtonPerimeter.Size = new System.Drawing.Size(75, 23);
            this.ButtonPerimeter.TabIndex = 11;
            this.ButtonPerimeter.Text = "Perimeter";
            this.ButtonPerimeter.UseVisualStyleBackColor = true;
            this.ButtonPerimeter.Click += new System.EventHandler(this.ButtonPerimeter_Click);
            // 
            // ButtonArea
            // 
            this.ButtonArea.Location = new System.Drawing.Point(430, 368);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.Size = new System.Drawing.Size(75, 23);
            this.ButtonArea.TabIndex = 12;
            this.ButtonArea.Text = "Area";
            this.ButtonArea.UseVisualStyleBackColor = true;
            this.ButtonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(47, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(458, 20);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Select a figure and enter the appropriate information in the field.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ButtonArea);
            this.Controls.Add(this.ButtonPerimeter);
            this.Controls.Add(this.groupBoxFigures);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "FigureStrike";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFigures.ResumeLayout(false);
            this.groupBoxFigures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.GroupBox groupBoxFigures;
        private System.Windows.Forms.RadioButton RadioButtonRhombus;
        private System.Windows.Forms.RadioButton RadioButtonSquare;
        private System.Windows.Forms.RadioButton RadioButtonRectangle;
        private System.Windows.Forms.RadioButton RadioButtonCircle;
        private System.Windows.Forms.RadioButton RadioButtonTriangle;
        private System.Windows.Forms.Button ButtonPerimeter;
        private System.Windows.Forms.Button ButtonArea;
        private System.Windows.Forms.Label Label4;
    }
}

