using System;
using System.Windows.Forms;
using System.Drawing;
using Task1;

namespace Task1WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string word = textBoxInput.Text;

                string result = Functions.SwapFirstAndLast(word);

                textBoxResult.Text = result;
            }
            catch (ArgumentException ex)
            {
                textBoxResult.Clear();

                MessageBox.Show(
                    ex.Message,
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Clear();

            textBoxInput.Focus();
        }
    }
}
