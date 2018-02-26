using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SangHung.MovieLib.Windows
{
    public partial class MovieLibrarySangHung : Form
    {
        public MovieLibrarySangHung()
        {
            InitializeComponent();
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var movie = new Movie();

            Decimal.TryParse("123", out var length);
            movie.Length = length;

            
            var title = movie.Title;
            movie.Title = "Movie A";
            movie.Owned = true;

            var error = movie.Validate();

            var lenth = movie.Length;

            var str = movie.ToString();

            var movieb = new Movie();
            movie.SetTitle("Movie B");
            error = movieb.Validate();

        }


        private void MovieLibrarySangHung_Load( object sender, EventArgs e )
        {

        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new MovieDetailForm("Add Movie");

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            _movie = form.Movie;
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            if (_movie == null)
            {
                MessageBox.Show("No Movie to edit");
                return;
            }
                        
            var form = new MovieDetailForm(_movie);

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            _movie = form.Movie;
        }
        private bool ShowConfirmation(string message, string title)
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            if (!ShowConfirmation("Are you sure", "Remove Movie"))
                return;

            MessageBox.Show("Movie has been deleted");
            _movie = null;
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void _HelpAbout_Click( object sender, EventArgs e )
        {

        }

        private Movie _movie;
    }
}
