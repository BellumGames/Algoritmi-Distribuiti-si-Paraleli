using System.IO;

namespace L4Client
{
    public partial class Client : Form
    {
        MyClient c = null;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            c = new MyClient();
            listViewChat.Items.Add(c.streamReader.ReadLine());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {   
            /*
            for (int i = 0; i < 50; i++)
            {
                ListViewItem item = new ListViewItem("Salut");
                listViewChat.Items.Add(item);
                listViewClients.Items.Add(new ListViewItem("Client " + i.ToString()));
            }*/
            c.stream.Close();
            c.client.Close();
        }
    }
}