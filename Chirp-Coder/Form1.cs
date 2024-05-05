namespace Chirp_Coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChirperClass CC = new();

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Input.Text))
            {

                return;
            }
            if (string.IsNullOrEmpty(CC.KEY)) 
            {

                return;
            }
            Output.Text =
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
            CC.KEY = Input.Text;
        }
    }
}
