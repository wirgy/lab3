using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "+";
        }

        private void Calculate()
        {
          try
           {
                // считали значения с полей для ввода и сконвертили в числа
                var Value1 = int.Parse(textBox1.Text);
                var Value2 = int.Parse(textBox2.Text);
                var Value3 = int.Parse(textBox3.Text);
                var Value4 = int.Parse(textBox4.Text);
                var Value5 = int.Parse(textBox5.Text);
                var Value6 = int.Parse(textBox6.Text);
                // на основании значений создали экземпляры нашего класса Vector 
                var firstVector = new Vector(Value1, Value2, Value3);
                var secondVector = new Vector(Value4, Value5, Value6);
               
                Vector sumVector;
                
                switch (comboBox1.Text)
                {
                    case "+":
                        // если плюсик выбрали, то складываем
                        sumVector = firstVector + secondVector;
                        break;
                    case "-":
                        // если минус, то вычитаем
                        sumVector = firstVector - secondVector;
                        break;
                    case "длина вектора":
                        sumVector = firstVector / secondVector;
                        break;
                  case "скалярное *":
                        sumVector = firstVector % secondVector;
                        break;
                    case "*":
                        sumVector = firstVector * secondVector;
                        break;
                    default:
                        // а если что-то другое, то просто 0 выводим,
                        sumVector = new Vector(0, 0, 0);
                        break;
                }
                // записали в поле txtResult длину в строковом виде
                if(comboBox1.Text == "длина вектора" || comboBox1.Text == "скалярное *") txtResult.Text = sumVector.Verbose2();
                else txtResult.Text = sumVector.Verbose();
            }
            catch (FormatException)
            {
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calculate();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
            switch (comboBox1.Text)
            {
                case "длина вектора":
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label3.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label12.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    textBox4.Text = "0";
                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    txtResult.Size = new Size(100, 20);
                    txtResult.Location = new Point(208, 117);
                    break;
                case "скалярное *":
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label3.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label9.Visible = false;
                    label12.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label10.Visible = false;
                    txtResult.Size = new Size(38, 20);
                    txtResult.Location = new Point(242, 116);
                    break;
                default:
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label3.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label12.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    txtResult.Size = new Size(60, 20);
                    txtResult.Location = new Point(232, 116);
                    break;
            }

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            txtResult.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
    }
}
