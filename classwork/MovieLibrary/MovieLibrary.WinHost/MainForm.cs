// ITSE 1430
// Movie Library
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    /// <summary>Main window.</summary>
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();

            //Additional init here
            //Runs at design time as well - be careful
        }
        #endregion

        #region Event Handlers


        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            UpdateUI();
        }

        //Called when File\Exit is selected
        private void OnFileExit ( object sender, EventArgs e )
        {
            //Confirm exit?
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;

            Close();
        }

        //Called when Help\About is selected
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var dlg = new AboutBox();
            //Blocks until child form is closed
            dlg.ShowDialog();

            //Show displays modeless, not blocking
            //dlg.Show();
            //MessageBox.Show("After Show");
        }

        //Called when Movie\Add is selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.StartPosition = FormStartPosition.CenterParent;
            //ShowDialog -> DialogResult
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save movie            
            _movie = dlg.Movie;
            UpdateUI();
        }

        //Called when Movie\Edit is selected
        private void OnMovieEdit ( object sender, EventArgs e )
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

        //Called when Movie\Delete is selected
        private void OnMovieDelete ( object sender, EventArgs e )
        {
            if (_movie == null)
                return;

            //Confirmation
            if (!Confirm($"Are you sure you want to delete '{_movie.Title}'?", "Delete"))
                return;

            //TODO: Delete
            _movie = null;
            UpdateUI();
        }
        #endregion

        #region Private Members

        // TODO : Remove this..
        private Movie _movie;

        private MovieDataBase _movies = new MovieDataBase();

        /// <summary>Updates UI whenever something has changed.</summary>
        private void UpdateUI ()
        {

            Movie[] movies = _movies.GetAll();
            var movie = movies[1] = new Movie();
            movie.Title = "Done";
            movie.Description = "Something";

            //Update movie list            
            

            var bindingSource = new BindingSource();
            bindingSource.DataSource = movies;

            //bind the movies to the listbox
            _listMovies.DataSource = bindingSource;
        }

        /// <summary>Displays a confirmation dialog.</summary>
        /// <param name="message">The confirmation message.</param>
        /// <param name="title">The confirmation title.</param>
        /// <returns>true if confirmed or false otherwise.</returns>
        private static bool Confirm ( string message, string title )
        {
            return MessageBox.Show(message, title,
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes;
        }

        #endregion        
    }
}
