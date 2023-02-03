namespace ClientForm
{
    public partial class Form1 : Form
    {
        private string _message = string.Empty;
        private Client.Client _client;

        public Form1()
        {
            InitializeComponent();
            _client = new Client.Client();

            ChatContent.Text = _client.ToString();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            _client.SendMessage(_message);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            _client.OnRecive += msg => ChatContent.Text += $"\n{msg}";
        }

        private void SendBox_TextChanged(object sender, EventArgs e)
        {
            _message = SendBox.Text;
        }
    }
}