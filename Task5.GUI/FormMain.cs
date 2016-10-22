using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5.Logic;

namespace Task5.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.FileName.Length > 100)
                {
                    labelFilePath.Text = ofd.FileName.Remove(100) + "...";
                }
                else
                {
                    labelFilePath.Text = ofd.FileName;
                }


                int? result = null;

                try
                {
                    int[] array = ArrayFill.ParseIntFromFile(ofd.FileName);

                    ShowArray(array);

                    result = ArraySearcher.LeftRightEqualIndex(array);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Array length must be between 0 and 1000 (0 < n1000)");
                    return;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Incorrect values inside the file");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


                ShowResults(result);
            }
        }

        private void ShowResults(int? result)
        {
            if (result == null)
                richTextBoxResults.Text += "Not found.";
            else
                richTextBoxResults.Text += "Index: " + result.ToString();
        }

        private void ShowArray(int[] array)
        {
            richTextBoxResults.Clear();

            StringBuilder sb = new StringBuilder(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i].ToString());
                sb.Append(" ");

                if ((i % 10 == 0) && (i > 0))
                    sb.Append(Environment.NewLine);
            }

            sb.Append(Environment.NewLine);
            richTextBoxResults.Text = sb.ToString();
        }

        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            try
            {
                int arraySize = Int32.Parse(textBoxArraySize.Text);

                int[] array = new int[arraySize];

                RandomFill.FillArray(array, int.MaxValue);

                ShowArray(array);

                int? result = ArraySearcher.LeftRightEqualIndex(array);

                ShowResults(result);

            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect array length value.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
