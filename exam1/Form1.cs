using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
   
        {
            bool allFieldsValid = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if ((string)textBox.Tag == "integer") // целое число 3-18
                    {
                        if (!int.TryParse(textBox.Text, out int value) || value < 3 || value > 18)
                        {
                            MessageBox.Show("Целое число должно быть от 3 до 18");
                            allFieldsValid = false;
                            return;
                        }
                    }
                    else if ((string)textBox.Tag == "real") // вещественное число < 4.5
                    {
                        if (!double.TryParse(textBox.Text, out double value) || value >= 4.5)
                        {
                            MessageBox.Show("Вещественное число должно быть меньше 4.5");
                            allFieldsValid = false;
                            return;
                        }
                    }
                    else if ((string)textBox.Tag == "text") // текст от 5 до 15 символов
                    {
                        var text = textBox.Text;
                        if (string.IsNullOrEmpty(text) || text.Length < 5 || text.Length > 15)
                        {
                            MessageBox.Show("Текст должен быть от 5 до 15 символов");
                            allFieldsValid = false;
                            return;
                        }
                    }
                }
            }

            if (allFieldsValid)
            {
                MessageBox.Show("Все поля правильно заполнены!");
            }
        }

    }
}
