using System.Data.OleDb;

namespace EKZLevik
{
    public partial class Form1 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Student\\Desktop\\students.mdb";

        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partners partners = new Partners();
            partners.Show();
        }
    }
}
