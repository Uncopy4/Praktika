using System.Diagnostics;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Input validation
            string inputString = inputTextBox.Text;
            string[] inputValues = inputString.Split(' ');

            int[] values = new int[inputValues.Length];
            for (int i = 0; i < inputValues.Length; i++)
            {
                if (!int.TryParse(inputValues[i], out values[i]))
                {
                    MessageBox.Show("Invalid input. Please enter integers separated by spaces.");
                    return;
                }
            }

            // Sorting and time measurement
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (bubbleSortRadioButton.Checked)
            {
                BubbleSort(values);
            }
            else if (insertionSortRadioButton.Checked)
            {
                InsertionSort(values);
            }
            else if (gnomeSortRadioButton.Checked)
            {
                GnomeSort(values);
            }
            else if (selectionSortRadioButton.Checked)
            {
                SelectionSort(values);
            }

            sw.Stop();

            // Display sorted array and sorting time
            sortedTextBox.Text = string.Join(" ", values);
            timeLabel.Text = $"Sorting time: {sw.Elapsed.TotalMilliseconds} ms";
        }

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        private void GnomeSort(int[] arr)
        {
            int i = 1, j = 2;
            while (i < arr.Length)
            {
                if (arr[i - 1] <= arr[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
        }

        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            sortedTextBox.Text = string.Empty;
            timeLabel.Text = string.Empty;
        }
    }
}