using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace snova
{
    public partial class Form1 : Form
    {
        private string serverIP = "127.0.0.1";
        private int serverPort = 12345;
        private UdpClient udpClient = new UdpClient();

        public Form1()
        {
            InitializeComponent();
            InitializeCommands();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeCommands()
        {
            comboBox1.Items.Add("draw pixel");
            comboBox1.Items.Add("draw line");
            comboBox1.Items.Add("draw rectangle");
            comboBox1.Items.Add("fill rectangle");
            comboBox1.Items.Add("draw ellipse");
            comboBox1.Items.Add("fill ellipse");
            comboBox1.Items.Add("draw circle");
            comboBox1.Items.Add("fill circle");
            comboBox1.Items.Add("draw text");
            comboBox1.Items.Add("draw image");
            comboBox1.SelectedIndex = 0;
        }

        private void SendCommandToServer(string command)
        {
            try
            {
                if (!IPAddress.TryParse(serverIP, out IPAddress ipAddress) || !IPAddress.IsLoopback(ipAddress))
                {
                    MessageBox.Show("Неверный IP-адрес сервера.");
                    return;
                }

                if (serverPort < 1 || serverPort > 65535)
                {
                    MessageBox.Show("Неверный порт сервера.");
                    return;
                }

                IPEndPoint serverEndPoint = new IPEndPoint(ipAddress, serverPort);
                byte[] data = Encoding.UTF8.GetBytes(command);
                udpClient.Send(data, data.Length, serverEndPoint);

                MessageBox.Show("Команда отправлена на сервер.");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Ошибка сокета: " + ex.SocketErrorCode.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке данных на сервер: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = comboBox1.SelectedItem.ToString();
            string parameters = textBox.Text;
            string fullCommand = command + ":" + parameters;
            SendCommandToServer(fullCommand);
        }
    }
}
