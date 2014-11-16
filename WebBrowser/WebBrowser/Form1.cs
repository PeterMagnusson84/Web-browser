using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Stänger webbläsaren när man trycker på avsluta under arkiv.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Öppnar en aboutbox när man trycker på Om i webbläsren.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skapad av Peter Magnusson");
        }

        //En webbsida öppnas när man trycker på denna sökknapp.
        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowserWindow.Navigate(searchBox.Text);
        }

        //Denna funktion kommer att köras varje gång enterknappen trycks när man är i sökrutan.
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
