using System;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Additional init here
            // Runs at design Time as well - be careful
        }
        private static bool Confirm ( string message, string title )
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void HandleFileExit ( object sender, EventArgs e )
        {
            // Confirm Exit?
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;
            Close();
        }        

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var dlg = new AboutBox();
            // blocks until child form is closed
            dlg.ShowDialog();

            // shows display modeless, not blocking
            //dlg.Show();
            //MessageBox.Show("After Show");
        }

        private void HandleMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.ShowDialog();
        }
    }
}
