using System;
using System.Windows.Forms;
using Task3;

namespace Task3WF
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Clear();

                string word = textBoxInput.Text;

                string result = Functions.RemoveVowels(word);

                textBoxResult.Text = result;

                if (result.Length == 0)
                {
                    MessageBox.Show(
                        "После удаления гласных букв получилась пустая строка.",
                        "Результат",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Clear();

            textBoxInput.Focus();
        }
    }
}
