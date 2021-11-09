using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_2
{
    public partial class Form1 : Form
    {
        private Triangle _triangle;

        private Circle _circle;

        private Rectangle _rectangle;

        private Square _square;

        private Rhombus _rhombus;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButtonTriangle.Checked = true;
        }
        private bool NewTriangle()
        {
            if (Triangle.Validate(Convert.ToDouble(TextBox1.Text),
                Convert.ToDouble(TextBox2.Text), Convert.ToDouble(TextBox3.Text)))
            {
                _triangle = new Triangle()
                {
                    SideAC = Convert.ToDouble(TextBox1.Text),
                    SideCB = Convert.ToDouble(TextBox2.Text),
                    SideAB = Convert.ToDouble(TextBox3.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! Data must be positive and the sum of the " +
                    "lengths of the two sides of the triangle must be less than the length of the third side.");
                return false;
            }
        }

        private bool NewCircle()
        {
            if (Circle.Validate(Convert.ToDouble(TextBox1.Text)))
            {
                _circle = new Circle()
                {
                    Radius = Convert.ToDouble(TextBox1.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! Radius must be postive.");
                return false;
            }
        }
        private bool NewRectangle()
        {
            if (Rectangle.Validate(Convert.ToDouble(TextBox1.Text),
                Convert.ToDouble(TextBox2.Text)))
            {
                _rectangle = new Rectangle()
                {
                    SideAC = Convert.ToDouble(TextBox1.Text),
                    SideAB = Convert.ToDouble(TextBox2.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! Sides must be postive.");
                return false;
            }
        }
        private bool NewSquare()
        {
            if (Square.Validate(Convert.ToDouble(TextBox1.Text)))
            {
                _square = new Square()
                {
                    Side = Convert.ToDouble(TextBox1.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! Side must be postive.");
                return false;
            }
        }

        private bool NewRhombus()
        {
            if (Rhombus.Validate(Convert.ToDouble(TextBox1.Text)))
            {
                _rhombus = new Rhombus()
                {
                    Side = Convert.ToDouble(TextBox1.Text)
                };
                return true;
            }
            else
            {
                MessageBox.Show("Input error! Data must be postive.");
                return false;
            }
        }
        private void RadioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "AC length:";
            Label2.Text = "CB length:";
            Label3.Text = "AB length:";
            Label2.Visible = true;
            TextBox2.Enabled = true;
            Label3.Visible = true;
            TextBox3.Enabled = true;
        }

        private void RadioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "Radius:";
            Label2.Visible = false;
            TextBox2.Enabled = false;
            Label3.Visible = false;
            TextBox3.Enabled = false;
        }

        private void RadioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "AC length:";
            Label2.Text = "AB length:";
            Label2.Visible = true;
            TextBox2.Enabled = true;
            Label3.Visible = false;
            TextBox3.Enabled = false;
        }

        private void RadioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "Side length:";
            Label2.Visible = false;
            TextBox2.Enabled = false;
            Label3.Visible = false;
            TextBox3.Enabled = false;
        }

        private void RadioButtonRhombus_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = "Side length:";
            Label2.Text = "Height:";
            Label2.Visible = true;
            TextBox2.Enabled = true;
            Label3.Visible = false;
            TextBox3.Enabled = false;
        }

        private void ButtonPerimeter_Click(object sender, EventArgs e)
        {
            if(RadioButtonTriangle.Checked && NewTriangle())
            {
                TextBoxResult.Text = Convert.ToString(_triangle.CalcPerimeter());
            }
            else if(RadioButtonCircle.Checked && NewCircle())
            {
                TextBoxResult.Text = Convert.ToString(_circle.CalcPerimeter());
            }
            else if(RadioButtonRectangle.Checked && NewRectangle())
            {
                TextBoxResult.Text = Convert.ToString(_rectangle.CalcPerimeter());
            }
            else if(RadioButtonSquare.Checked && NewSquare())
            {
                TextBoxResult.Text = Convert.ToString(_square.CalcPerimeter());
            }
            else if(RadioButtonRhombus.Checked && NewRhombus())
            {
                TextBoxResult.Text = Convert.ToString(_rhombus.CalcPerimeter());
            }
        }

        private void ButtonArea_Click(object sender, EventArgs e)
        {
            if (RadioButtonTriangle.Checked && NewTriangle())
            {
                TextBoxResult.Text = Convert.ToString(_triangle.CalcArea());
            }
            else if (RadioButtonCircle.Checked && NewCircle())
            {
                TextBoxResult.Text = Convert.ToString(_circle.CalcArea());
            }
            else if (RadioButtonRectangle.Checked && NewRectangle())
            {
                TextBoxResult.Text = Convert.ToString(_rectangle.CalcArea());
            }
            else if (RadioButtonSquare.Checked && NewSquare())
            {
                TextBoxResult.Text = Convert.ToString(_square.CalcArea());
            }
            else if (RadioButtonRhombus.Checked && NewRhombus())
            {
                if ((TextBox2.Text != "") && (Rhombus.Validate(Convert.ToDouble(TextBox2.Text))))
                {
                    _rhombus.Height = Convert.ToDouble(TextBox2.Text);
                    TextBoxResult.Text = Convert.ToString(_rhombus.CalcArea());
                }
                else
                {
                    MessageBox.Show("Input error! Height must be positive.");
                }
            }
        }
    }
}
