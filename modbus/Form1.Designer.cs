namespace modbus
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdresseIP = new System.Windows.Forms.TextBox();
            this.buttonConnexion_Click = new System.Windows.Forms.Button();
            this.buttonDeconnexion_Click = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxStatut = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.buttonLireTension = new System.Windows.Forms.Button();
            this.textBoxTension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip seveur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAdresseIP
            // 
            this.textBoxAdresseIP.AccessibleDescription = "textBoxAdresseIP";
            this.textBoxAdresseIP.AccessibleName = "textBoxAdresseIP";
            this.textBoxAdresseIP.Location = new System.Drawing.Point(76, 46);
            this.textBoxAdresseIP.Name = "textBoxAdresseIP";
            this.textBoxAdresseIP.Size = new System.Drawing.Size(279, 20);
            this.textBoxAdresseIP.TabIndex = 1;
            this.textBoxAdresseIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonConnexion_Click
            // 
            this.buttonConnexion_Click.Location = new System.Drawing.Point(380, 44);
            this.buttonConnexion_Click.Name = "buttonConnexion_Click";
            this.buttonConnexion_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion_Click.TabIndex = 2;
            this.buttonConnexion_Click.Text = "Connexion";
            this.buttonConnexion_Click.UseVisualStyleBackColor = true;
            this.buttonConnexion_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeconnexion_Click
            // 
            this.buttonDeconnexion_Click.Location = new System.Drawing.Point(482, 44);
            this.buttonDeconnexion_Click.Name = "buttonDeconnexion_Click";
            this.buttonDeconnexion_Click.Size = new System.Drawing.Size(85, 23);
            this.buttonDeconnexion_Click.TabIndex = 3;
            this.buttonDeconnexion_Click.Text = "Deconnexion";
            this.buttonDeconnexion_Click.UseVisualStyleBackColor = true;
            this.buttonDeconnexion_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxStatut
            // 
            this.textBoxStatut.Location = new System.Drawing.Point(593, 44);
            this.textBoxStatut.Name = "textBoxStatut";
            this.textBoxStatut.Size = new System.Drawing.Size(176, 184);
            this.textBoxStatut.TabIndex = 5;
            this.textBoxStatut.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(772, 39);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 184);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // buttonLireTension
            // 
            this.buttonLireTension.Location = new System.Drawing.Point(380, 124);
            this.buttonLireTension.Name = "buttonLireTension";
            this.buttonLireTension.Size = new System.Drawing.Size(75, 23);
            this.buttonLireTension.TabIndex = 9;
            this.buttonLireTension.Text = "Tension";
            this.buttonLireTension.UseVisualStyleBackColor = true;
            this.buttonLireTension.Click += new System.EventHandler(this.buttonLireTension_Click);
            // 
            // textBoxTension
            // 
            this.textBoxTension.Location = new System.Drawing.Point(482, 124);
            this.textBoxTension.Name = "textBoxTension";
            this.textBoxTension.Size = new System.Drawing.Size(85, 20);
            this.textBoxTension.TabIndex = 10;
            this.textBoxTension.TextChanged += new System.EventHandler(this.textBoxTension_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tension moteur en Volt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTension);
            this.Controls.Add(this.buttonLireTension);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBoxStatut);
            this.Controls.Add(this.buttonDeconnexion_Click);
            this.Controls.Add(this.buttonConnexion_Click);
            this.Controls.Add(this.textBoxAdresseIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdresseIP;
        private System.Windows.Forms.Button buttonConnexion_Click;
        private System.Windows.Forms.Button buttonDeconnexion_Click;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox textBoxStatut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button buttonLireTension;
        private System.Windows.Forms.TextBox textBoxTension;
        private System.Windows.Forms.Label label2;
    }
}

