using System;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            case 0: // прямоугольник                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;                case 1: // круг
                    fig = new circle((double)size1_numericUpDown.Value); break;
                case 2: // треугольник                    fig = new triangle((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;                case 3: // трапеция
                    fig = new trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)numericUpDown1.Value); break;
        }
        protocol_listBox.Items.Add(fig.ToString() + ": S=" + fig.Square());
        }
    private void figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (figure_comboBox.SelectedIndex == 0)
        {
            label2.Text = "Длина"; size2_numericUpDown.Visible = true;
            label3.Visible = true; label3.Text = "Ширина";
            label4.Visible = false; numericUpDown1.Visible = false;
        }
        if (figure_comboBox.SelectedIndex == 1)
        {
            label2.Text = "Радиус";
            size2_numericUpDown.Visible = false; label3.Visible = false;
            label4.Visible = false; numericUpDown1.Visible = false;
        }
        if (figure_comboBox.SelectedIndex == 2)
        {
            label2.Text = "основание";
            size2_numericUpDown.Visible = true; label3.Visible = true;
            label3.Text = "высота"; label4.Visible = false;
            numericUpDown1.Visible = false;
        }
        if (figure_comboBox.SelectedIndex == 3)
        {
            label2.Text = "Б.основание"; size2_numericUpDown.Visible = true;
            label3.Visible = true; label3.Text = "М.основание";
            label4.Visible = true; numericUpDown1.Visible = true;
            label4.Text = "Высота";
        }
    }
}

        
           

