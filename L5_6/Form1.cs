using System.Data.SqlClient;
using System.Windows.Forms;

namespace L5_6
{
    public partial class Form1 : Form
    {
        public List<int> id = new List<int>();
        public List<string> nume = new List<string>();
        public List<double> medie = new List<double>();

        public Form1()
        {
            InitializeComponent();
            ConnectToDB();
            //InitDataGridView();
        }

        private void dataGridView_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (dataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        public void ConnectToDB() 
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\muica\\OneDrive\\Laptop\\Algo Distrib\\L2\\Laboratoare\\L5_6\\Student.mdf\";Integrated Security=True";
            string queryString = "SELECT * FROM dbo.Student";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    id.Add(reader.GetInt32(0));
                    nume.Add(reader.GetString(1));
                    medie.Add(reader.GetDouble(2));
                }
            }
        }

        public void InitDataGridView() 
        {
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nume";
            dataGridView.Columns[2].Name = "Medie";

            dataGridView.DefaultCellStyle.Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Regular);
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);

            //dataGridView.Rows.Add(data[0]);
        }
    }
}