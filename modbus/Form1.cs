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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void label1_Click(object sendSer, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération - adresse
                string adresseIP = textBoxAdresseIP.Text;

                // Affichage - tentative
                textBoxStatut.Text += $"Connexion au serveur {adresseIP}\r\n";

                // Création - socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Conversion - adresse
                IPAddress ipAddress = IPAddress.Parse(adresseIP);

                // Création - endpoint
                IPEndPoint endPoint = new IPEndPoint(ipAddress, 502); // Port Modbus standard

                // Connexion - serveur
                socket.Connect(endPoint);

                // Affichage - succès
                textBoxStatut.Text += "Connexion ok\r\n";

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
            catch (System.Net.Sockets.SocketException se)
            {
                // Erreur - socket
                textBoxStatut.Text += "**Exception : Impossible de se connecter au serveur\r\n";
                textBoxStatut.Text += "Message : " + se.Message + "\r\n";

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
            catch (System.Exception ex)
            {
                // Erreur - générale
                textBoxStatut.Text += "**Exception : Impossible de se connecter au serveur\r\n";
                textBoxStatut.Text += "Message : " + ex.Message + "\r\n";

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification - socket
                if (socket != null)
                {
                    // Fermeture - connexion
                    socket.Close();

                    // Affichage - succès
                    textBoxStatut.Text += "Déconnexion réussie\r\n";
                }
                else
                {
                    // Affichage - aucune
                    textBoxStatut.Text += "Aucune connexion active\r\n";
                }

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
            catch (System.Exception ex)
            {
                // Erreur - déconnexion
                textBoxStatut.Text += "**Exception lors de la déconnexion\r\n";
                textBoxStatut.Text += "Message : " + ex.Message + "\r\n";

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void buttonLireTension_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification - connexion
                if (socket == null || !socket.Connected)
                {
                    textBoxStatut.Text += "Erreur : Pas de connexion active\r\n";
                    textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                    textBoxStatut.ScrollToCaret();
                    return;
                }

                // Trame - lecture
                var trameE = new byte[] {
                    0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x06,
                    0x01,
                    0x03,
                    0x0C, 0x86,
                    0x00, 0x01
                };

                // Affichage - envoi
                textBoxStatut.Text += "Envoi demande lecture tension...\r\n";

                // Affichage - trame envoyée
                string hexEnvoi = "Trame envoyée : ";
                for (int i = 0; i < trameE.Length; i++)
                {
                    hexEnvoi += String.Format("{0:X2} ", trameE[i]);
                }
                textBoxStatut.Text += hexEnvoi + "\r\n";

                // Envoi - trame
                int bytesSent = socket.Send(trameE);
                textBoxStatut.Text += $"Envoyé : {bytesSent} bytes\r\n";

                // Réception - buffer
                var trameR = new byte[256];

                // Réception - données
                int bytesReceived = socket.Receive(trameR);
                textBoxStatut.Text += $"Reçu : {bytesReceived} bytes\r\n";

                // Affichage - hexadécimal
                string hexString = "Trame reçue : ";
                for (int i = 0; i < bytesReceived; i++)
                {
                    hexString += String.Format("{0:X2} ", trameR[i]);
                }
                textBoxStatut.Text += hexString + "\r\n";

                // Vérification - réponse
                if (bytesReceived >= 9 && trameR[7] == 0x03)
                {
                    int tensionRaw = (trameR[9] << 8) | trameR[10];
                    double tension = tensionRaw / 10.0;

                    textBoxTension.Text = String.Format("{0:F1} V", tension);
                    textBoxStatut.Text += String.Format("Tension : {0:F1} V (Raw: {1:X4})\r\n", tension, tensionRaw);
                }
                else
                {
                    // Affichage - erreur
                    textBoxStatut.Text += "Erreur dans la réponse Modbus\r\n";
                }

                // Défilement - automatique
                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
            catch (System.Exception ex)
            {
                textBoxTension.Text = "Erreur";
                textBoxStatut.Text += "**Exception lors de la lecture tension\r\n";
                textBoxStatut.Text += "Message : " + ex.Message + "\r\n";

                textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
                textBoxStatut.ScrollToCaret();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTension_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
