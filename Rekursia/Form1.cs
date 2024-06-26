namespace Rekursia
{
    public partial class Form1 : Form
    {
        private List<int> nums = new() { 1, 3, 3, 7, 9 };
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addElm();
            MessageBox.Show(string.Join(", ", nums).ToString());
        }

        private void addElm(int n = 0)
        {
            if (n > 100)
                return;
            int rand = new Random().Next(10);
            foreach (int num in nums)
            {
                if (num == rand)
                    addElm(n + 1);
            }
            nums.Add(rand);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}