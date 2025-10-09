using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace modbus
{
    public partial class Form1 : Form
    {
        private Socket socket;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "Connexion au serveur 172.17.50.180..";

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Récupérer l'adresse IP depuis la textbox
                string adresseIP = textBox1.Text;

                // Créer l'objet IPEndPoint (adresse IP + port Modbus 502)
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(adresseIP), 502);

                // Connecter la socket au serveur
                socket.Connect(endPoint);

                // Afficher le message de succès
                textBox1.Text += "Connexion ok\r\n";
            }

            catch (System.Net.Sockets.SocketException se)
            {
                this.textBox1.Text += "**Exception : Impossible de se connecter au serveur\r\n";
            }

            catch (Exception ex)
            {
                textBox1.Text += "**Exception : " + ex.Message + "\r\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
