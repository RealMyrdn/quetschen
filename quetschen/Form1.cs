using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace quetschen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string komprimiert = logik.Programm.Quetschen(input);
            textBox2.Text = komprimiert;
            label4.Text = (textBox2.Text.Length).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = (textBox1.Text.Length).ToString();
        }
    }
}
