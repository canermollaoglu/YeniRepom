namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme");
            MessageBox.Show("ikinci commit");
            string test = "deneme";
            int a = 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yeniMesaj = "yeni bir mesaj ekliyoruz.";
        }
    }
}
