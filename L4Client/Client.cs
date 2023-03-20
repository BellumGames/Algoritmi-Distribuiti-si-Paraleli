using System.IO;

namespace L4Client
{
    public partial class Client : Form
    {
        public MyClient c = null;
        public static int clientIndex = -1;
        public static string clientName = string.Empty;
        public static Dictionary<int, List<string>> log = new Dictionary<int, List<string>>();

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            M form = new M();
            form.Show();
        }

        //c = new MyClient();

        public void RefreshMessages()
        {
            int destinationIndex = int.Parse(listBoxClients.SelectedIndex.ToString());
            listViewChat.Clear();
            foreach (string message in log[destinationIndex])
            {
                listViewChat.Items.Add(message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int destination = listBoxClients.SelectedIndex;
            if (destination == null) 
            {
                return;
            }
            string message = textBoxMessage.Text;
            if (message.Equals(string.Empty) || message.Equals(null)) 
            {
                return;
            }
            if (log.ContainsKey(destination))
            {
                log[destination].Add(message);
            }
            else 
            {
                List<string> temp = new List<string>();
                temp.Add(message);
                log.Add(destination, temp);
            }
            message = clientIndex + message + destination;
            c.streamWriter.WriteLine(message);
        }
    }
}