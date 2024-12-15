using MVPAreaFinder.Presenters;
using MVPAreaFinder.Views;

namespace MVPAreaFinder
{
    public partial class Form1 : Form, IFinder
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string rectangleWidthText
        {
            get
            {
                return textBoxWidth.Text;
            }
            set
            {
                textBoxWidth.Text = value;
            }
        }
        public string rectangleHeightText
        {
            get
            {
                return textBoxHeight.Text;
            }
            set
            {
                textBoxHeight.Text = value;
            }
        }
        public string squareLengthText
        {
            get
            {
                return textBoxWidth.Text;
            }
            set
            {
                textBoxWidth.Text = value;
            }
        }
        public string AreaResultText
        {
            set
            {
                labelResult.Text = value;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            FinderPresenter presenter = new FinderPresenter(this);

            if (comboBoxShapes.SelectedIndex == 0)
            {
                if (textBoxWidth.Text != "" && textBoxHeight.Text != "")
                {
                    presenter.CalculateRectangleArea();
                }
                else
                {
                    MessageBox.Show("Missing Value(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBoxShapes.SelectedIndex == 1)
            {
                if (textBoxWidth.Text != "")
                {
                    presenter.CalculateSquareArea();
                }
                else
                {
                    MessageBox.Show("Missing Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select a Shape", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShapes.SelectedIndex == 0)
            {
                textBoxHeight.Clear();
                textBoxWidth.Clear();
                textBoxHeight.Enabled = true;
                labelWidth.Text = "Width  :";
            }
            if (comboBoxShapes.SelectedIndex == 1)
            {
                textBoxHeight.Clear();
                textBoxWidth.Clear();
                textBoxHeight.Enabled = false;
                labelWidth.Text = "Length :";
            }
        }
    }
}
