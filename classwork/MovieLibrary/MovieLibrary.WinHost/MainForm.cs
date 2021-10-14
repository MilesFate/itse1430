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
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            UpdateUI();
            _movie = dlg.Movie;
        }

        private void HandleMovieEdit ( object sender, EventArgs e )
        {
            if (_movie == null)
                return;

            var dlg = new MovieForm();
            dlg.Movie = _movie;

            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            //TODO: Save movie            
            _movie = dlg.Movie;
            UpdateUI();
        }

        private void UpdateUI ()
        {
            var movies = (_movie != null) ? new Movie[1] : new Movie[0];
            if (_movie != null)
                movies[0] = _movie;

            var bindingSource = new BindingSource();
            bindingSource.DataSource = movies;

            //bind the movies to the listbox
            _listMovies.DataSource = bindingSource;
        }

        private Movie _movie;

        private void HandleMovieDelete ( object sender, EventArgs e )
        {
            if (_movie == null)
                return;
            if (!Confirm($"are you sure you want to delete {_movie.Title}?", "delete"))
                return;
            _movie = null;
            UpdateUI();
        }
    }
}
