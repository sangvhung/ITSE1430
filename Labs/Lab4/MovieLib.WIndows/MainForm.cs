/*
 * ITSE 1430
 * Sample implementation
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLib.Data.Memory;

namespace MovieLib.Windows
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieDetailForm(_database);

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            UpdateMovies();
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {            
            var selectedMovie = GetSelectedMovie(true);
            if (selectedMovie == null)
                return;
            
            var form = new MovieDetailForm(_database);
            form.Movie = selectedMovie;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            UpdateMovies();
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            var selectedMovie = GetSelectedMovie(true);
            if (selectedMovie == null)
                return;

            //Display a confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete\r\n{selectedMovie.Title}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _database.Remove(selectedMovie.Id);
            UpdateMovies();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            new AboutForm().ShowDialog(this);
        }
        #endregion

        #region Private Members

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(this, message, title ?? "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Movie GetSelectedMovie ( bool showErrorIfNone )
        {
            var movie = _bsMovies.Current as Movie;

            if (movie == null && showErrorIfNone)
                DisplayError("No movie selected.", "No Movie");

            return movie;
        }

        private void UpdateMovies ()
        {
            //Get the movies
            var movies = _database.GetAll();

            _bsMovies.SuspendBinding();
            _bsMovies.DataSource = movies;
            _bsMovies.ResumeBinding();
        }

        private IMovieDatabase _database = new MemoryMovieDatabase();
        #endregion

        private void OnCellDoubleClicked ( object sender, DataGridViewCellEventArgs e )
        {
            //Verify that a movie was clicked
            if (e.RowIndex < 0)
                return;

            OnMovieEdit(sender, EventArgs.Empty);
        }

        private void OnGridKeyDown ( object sender, KeyEventArgs e )
        {
            var selectedMovie = GetSelectedMovie(false);
            if (selectedMovie == null)
                return;

            //For ENTER, go into edit mode
            if (e.KeyCode == Keys.Return)
            {
                OnMovieEdit(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            } else if (e.KeyCode == Keys.Delete)
            {
                OnMovieDelete(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            };
        }
    }
}
