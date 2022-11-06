        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                string s = "";
                s = cd.Color.Name;
                label1.ForeColor = cd.Color;

            }
        }
