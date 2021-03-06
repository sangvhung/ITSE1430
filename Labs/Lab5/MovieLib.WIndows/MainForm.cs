﻿/*
 * ITSE 1430 Lab3
 * Sang Hung
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLib.Data;
using MovieLib.Data.Memory;
using MovieLib.Data.Sql;

namespace MovieLib.Windows
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];
            _database = new SqlMovieDatabase(connString.ConnectionString);

            RefreshUI();
        }

        #region Event Handlers
        //Called when a cell is double clicked
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            EditMovie(movie);
        }
        //Called when a key is pressed while in a cell
        private void OnCellKeyDown(object sender, KeyEventArgs e)
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            if(e.KeyCode ==Keys.Delete)
            {
                e.Handled = true;
                DeleteMovie(movie);
            }else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                EditMovie(movie);
            };
        }
        private void OnFileExit ( object sende, EventArgs e )
        {
            Close();
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new MovieDetailForm("Add Movie");

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Add to database
            try
            {
                _database.Add(form.Movie);
            
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };


            RefreshUI();
        }

        private void OnMovieEdit ( object sende, EventArgs e )
        {
            //Get selected movie
            
            var movie = GetSelectedMovie();
            if(movie == null)
            {
                MessageBox.Show(this, "No movie selected", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            EditMovie(movie);
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie();
            if(movie == null)
            {
                MessageBox.Show(this, "No movie selected", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            DeleteMovie(movie);
        }

        private void OnHelpAbout ( object sende, EventArgs e )
        {
            new AboutForm().ShowDialog(this);
        }
        #endregion

        #region Private Members
        //Helper Method to handle deleting movies
        private void DeleteMovie(Movie movie)
        {
            if (!ShowConfirmation("Are you sure?", "Remove Movie"))
                return;

            //Remove movie
            try
            {
                _database.Remove(movie.Id);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            };

            RefreshUI();
        }
        //Helper method to handle editing products
        private void EditMovie(Movie movie)
        {
            var form = new MovieDetailForm(movie);
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Update the product
            form.Movie.Id = movie.Id;
            try
            {
                _database.Update(form.Movie);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            };

            RefreshUI();
        }
        private Movie GetSelectedMovie()
        {
            if (dataGridView2.SelectedRows.Count > 0)
                return dataGridView2.SelectedRows[0].DataBoundItem as Movie;

            return null;
        }
        private void RefreshUI()
        {
            IEnumerable<Movie> movies = null;
            try
            {
                movies = _database.GetAll();
            } catch (Exception)
            {
                MessageBox.Show("Error loading movies");
            };

            movieBindingSource.DataSource = movies?.ToList();
        }
        private bool ShowConfirmation(string message, string title)
        {
            return MessageBox.Show(this, message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }

        private IMovieDatabase _database;
        #endregion
    }
}
