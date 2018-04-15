using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MovieLib.Windows
{
    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm ()
        {
            InitializeComponent();
        }

        public MovieDetailForm ( IMovieDatabase database ) : this()
        {
            _database = database;
        }

        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            //Load the data
            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();

                _cbIsOwned.Checked = Movie.IsOwned;
            };

            //Trigger validation
            ValidateChildren();
        }

        #region Event Handlers

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //Save the data
            var movie = CreateMovie();
            if (movie.Id == 0)
                movie = _database.Add(movie);
            else
                movie = _database.Update(movie);

            if (movie == null)
            {
                DisplayError("Save failed.", "Error");
                return;
            };

            Movie = movie;            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnValidateTitle ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Title is required");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        private void OnValidateLength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var length = ParseInt32(control.Text);
            if (length < 0)
            {
                _errors.SetError(control, "Length must be >= 0");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        #endregion

        #region Private Members

        private Movie CreateMovie ( )
        {
            //Create a new movie
            var movie = new Movie()
            {
                Title = _txtTitle.Text,
                Description = _txtDescription.Text,
                IsOwned = _cbIsOwned.Checked,
                Length = ParseInt32(_txtLength.Text)
            };

            //If this is an update then set the ID as well
            if (Movie != null)
                movie.Id = Movie.Id;

            return movie;
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(this, message, title ?? "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int ParseInt32 ( string text )
        {
            if (String.IsNullOrEmpty(text))
                return 0;

            if (Int32.TryParse(text, out int value))
                return value;

            return -1;
        }

        private readonly IMovieDatabase _database;
        #endregion        
    }
}
