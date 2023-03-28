using Microsoft.CSharp.RuntimeBinder;


namespace L5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectToDB() 
        {
            /*
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\muica\\OneDrive\\Laptop\\Algo Distrib\\L2\\Laboratoare\\L5_6\\Student.mdf\";Integrated Security=True";
            string queryString = "SELECT * FROM Student";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            */
        }
    }
}