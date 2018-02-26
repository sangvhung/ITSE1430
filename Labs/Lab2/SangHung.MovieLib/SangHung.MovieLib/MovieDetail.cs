using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SangHung.MovieLib
{
    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm()
        {
            InitializeComponent();
        }
        public MovieDetailForm(string title) : this()
        {
            Text = title;
        }
        public MovieDetailForm(Movie movie) : this("Edit Product")
        {
            Movie = movie;
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Movie !=null)
            {
                //Load Product
                _Title.Text = Movie.Title;
                _Description.Text = Movie.Description;
                _Length.Text = Movie.Length.ToString();
                _ChkOwned.Checked = Movie.Owned;
            };

            ValidateChildren();
        }

        public Movie Movie { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var movie = new Movie();
            movie.Title = _Title.Text;
            movie.Description = _Description.Text;
            movie.Length = ShowLength(_Length);
            movie.Owned = _ChkOwned.Checked;

            var message = movie.Validate();
            if(!String.IsNullOrEmpty(message))
            {
                DisplayError(message);
                return;
            };

            Movie = movie;
            DialogResult = DialogResult.OK;

            Close();
        }

        private decimal ShowLength(TextBox control)
        {
            if (Decimal.TryParse(control.Text, out var length))
                return length;

            return -1;
        }

        private void DisplayError(string message)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _Description_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as TextBox;
            var length = ShowLength(textBox);
            if(length < 0)
            {
                //_errorProvider.SetError(textBox, "Length must be >=0");
                e.Cancel = true;
            }
        }

        private void OnCancel( object sender, EventArgs e )
        {
            //Shortcut on form for cancel button
        }
    }
}
