using System;
using System.Windows.Forms;
using Task2;

namespace Task2WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxResult.Items.Clear();

                string sequence = textBoxInput.Text;

                string[] repeatedWords =
                    Functions.FindRepeatedWords(sequence);

                if (repeatedWords.Length == 0)
                {
                    MessageBox.Show(
                        "Слов, встречающихся несколько раз, нет.",
                        "Результат",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                listBoxResult.Items.AddRange(repeatedWords);
            }
            catch (ArgumentException ex)
            {
                listBoxResult.Items.Clear();

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
            listBoxResult.Items.Clear();

            textBoxInput.Focus();
        }
    }
}
