namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int a, b, c;
            a = Cursor.Position.X;
            b = Cursor.Position.Y;

            button1.Location = new Point(a, b-30);

            button1.Size = new Size(200, 100);

            button1.Parent = this;
            button1.Visible = true;

            button1.Text = Convert.ToString(a) +" "+ Convert.ToString(b);
        }
    }
}