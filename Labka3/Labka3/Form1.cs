using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Labka3
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private string SendCommandToServer(string command)
        {
            try
            {
                if (!IPAddress.TryParse(serverIP, out IPAddress ipAddress) || !IPAddress.IsLoopback(ipAddress))
                {
                    return "Неверный IP-адрес сервера.";
                }

                if (serverPort < 1 || serverPort > 65535)
                {
                    return "Неверный порт сервера.";
                }

                IPEndPoint serverEndPoint = new IPEndPoint(ipAddress, serverPort);
                byte[] data = Encoding.UTF8.GetBytes(command);
                udpClient.Send(data, data.Length, serverEndPoint);

                byte[] receivedData = udpClient.Receive(ref serverEndPoint);
                string result = Encoding.UTF8.GetString(receivedData);
                return result;
            }
            catch (SocketException ex)
            {
                // Обработка ошибок сокета
                return "Ошибка сокета: " + ex.SocketErrorCode.ToString();
            }
            catch (Exception ex)
            {
                // Обработка других исключений
                return "Ошибка при отправке/получении данных от сервера: " + ex.Message;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string command = comboBox1.SelectedItem.ToString();
            string parameters = textBox.Text;
            string fullCommand = command + ":" + parameters;

            string result = SendCommandToServer(fullCommand);
            ооооо.Text = result;
        }
    }
}
