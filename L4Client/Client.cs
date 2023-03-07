namespace L4Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < 50; i++)
            {
                ListViewItem item = new ListViewItem("Salut");
                listViewChat.Items.Add(item);
                listViewClients.Items.Add(new ListViewItem("Client " + i.ToString()));
            }
        }
    }
}