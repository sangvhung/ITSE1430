namespace SangHung.MovieLib.Windows
{
    partial class MovieLibrarySangHung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MovieAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._MovieEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._MovieDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MainMenu
            // 
            this._MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._MainMenu.Location = new System.Drawing.Point(0, 0);
            this._MainMenu.Name = "_MainMenu";
            this._MainMenu.Size = new System.Drawing.Size(684, 24);
            this._MainMenu.TabIndex = 0;
            this._MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _MenuExit
            // 
            this._MenuExit.Name = "_MenuExit";
            this._MenuExit.Size = new System.Drawing.Size(92, 22);
            this._MenuExit.Text = "E&xit";
            this._MenuExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MovieAdd,
            this._MovieEdit,
            this._MovieDelete});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "&Movies";
            // 
            // _MovieAdd
            // 
            this._MovieAdd.Name = "_MovieAdd";
            this._MovieAdd.Size = new System.Drawing.Size(152, 22);
            this._MovieAdd.Text = "&Add Movie";
            this._MovieAdd.Click += new System.EventHandler(this.OnMovieAdd);
            // 
            // _MovieEdit
            // 
            this._MovieEdit.Name = "_MovieEdit";
            this._MovieEdit.Size = new System.Drawing.Size(152, 22);
            this._MovieEdit.Text = "&Edit Movie";
            this._MovieEdit.Click += new System.EventHandler(this.OnMovieEdit);
            // 
            // _MovieDelete
            // 
            this._MovieDelete.Name = "_MovieDelete";
            this._MovieDelete.Size = new System.Drawing.Size(152, 22);
            this._MovieDelete.Text = "&Delete";
            this._MovieDelete.Click += new System.EventHandler(this.OnMovieDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._HelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _HelpAbout
            // 
            this._HelpAbout.Name = "_HelpAbout";
            this._HelpAbout.Size = new System.Drawing.Size(107, 22);
            this._HelpAbout.Text = "About";
            this._HelpAbout.Click += new System.EventHandler(this._HelpAbout_Click);
            // 
            // MovieLibrarySangHung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this._MainMenu);
            this.MainMenuStrip = this._MainMenu;
            this.Name = "MovieLibrarySangHung";
            this.Text = "Movie Library SangHung";
            this.Load += new System.EventHandler(this.MovieLibrarySangHung_Load);
            this._MainMenu.ResumeLayout(false);
            this._MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MenuExit;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MovieAdd;
        private System.Windows.Forms.ToolStripMenuItem _MovieEdit;
        private System.Windows.Forms.ToolStripMenuItem _MovieDelete;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _HelpAbout;
    }
}

