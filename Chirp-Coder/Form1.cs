namespace Chirp_Coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly ChirperClass CC = new();

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Input.Text.Trim()))
            {

                //return;
            }
            if (string.IsNullOrEmpty(CC.KEY.Trim()))
            {

                //return;
            }
            Output.Text = CC.ChirpIT(Input.Text.Trim());
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
            CC.KEY = Input.Text;
        }

        private void DecodeCB_CheckedChanged(object sender, EventArgs e)
        {
            CC.Decoding = DecodeCB.Checked;
        }
    }
}
