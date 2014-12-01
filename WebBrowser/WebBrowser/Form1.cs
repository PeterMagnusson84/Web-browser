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
            MessageBox.Show("Skapad av: Peter Magnusson \r\n\n Version: 0.000001 ALPHA");
        }

        //En webbsida öppnas när man trycker på denna sökknapp.
        private void searchButton_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        //Denna funktion sköter all navigering och efterbearbetning.
        private void NavigateToPage()
        {
            loadingStatus.Text = "Laddar sidan";
            webBrowserWindow.Navigate(searchBox.Text);
            webBrowserWindow.ScriptErrorsSuppressed = true;
        }

        //Denna funktion kommer att köras varje gång en knapp trycks när man är i sökrutan.
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Om man trycker på enter händer detta.
            if(e.KeyChar == (char) ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        //När något i webbläsarens innehåll ändras.
        private void webBrowserWindow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                loadingProgressBar.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
            
        }

        private void webBrowserWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadingStatus.Text = "Klar";
        }
    }
}
