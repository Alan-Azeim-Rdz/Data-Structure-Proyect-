namespace Data_Structure__Proyect_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDataStructure_Click(object sender, EventArgs e)
        {
            LinearDataStructure linearDataStructure = new LinearDataStructure();
            linearDataStructure.Show();
        }

        private void BtnSearchAlgorithms_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void BtnOrdenamentAlg_Click(object sender, EventArgs e)
        {
            Sortin sortin = new Sortin();
            sortin.Show();
        }
    }
}
