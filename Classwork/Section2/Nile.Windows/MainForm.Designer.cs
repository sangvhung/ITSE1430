namespace Nile.Windows
{
    partial class MainForm
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
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._ProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._ProductRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MainMenu
            // 
            this._MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._MainMenu.Location = new System.Drawing.Point(0, 0);
            this._MainMenu.Name = "_MainMenu";
            this._MainMenu.Size = new System.Drawing.Size(723, 24);
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
            this._MenuExit.Size = new System.Drawing.Size(152, 22);
            this._MenuExit.Text = "E&xit";
            this._MenuExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ProductAdd,
            this._ProductEdit,
            this.toolStripSeparator1,
            this._ProductRemove});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // _ProductAdd
            // 
            this._ProductAdd.Name = "_ProductAdd";
            this._ProductAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._ProductAdd.Size = new System.Drawing.Size(141, 22);
            this._ProductAdd.Text = "&Add";
            this._ProductAdd.Click += new System.EventHandler(this.OnProductAdd);
            // 
            // _ProductEdit
            // 
            this._ProductEdit.Name = "_ProductEdit";
            this._ProductEdit.Size = new System.Drawing.Size(152, 22);
            this._ProductEdit.Text = "&Edit";
            this._ProductEdit.Click += new System.EventHandler(this.OnProductEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // _ProductRemove
            // 
            this._ProductRemove.Name = "_ProductRemove";
            this._ProductRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._ProductRemove.Size = new System.Drawing.Size(152, 22);
            this._ProductRemove.Text = "&Remove";
            this._ProductRemove.Click += new System.EventHandler(this.OnProductRemove);
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
            this._HelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._HelpAbout.Size = new System.Drawing.Size(152, 22);
            this._HelpAbout.Text = "About";
            this._HelpAbout.Click += new System.EventHandler(this._HelpAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 475);
            this.Controls.Add(this._MainMenu);
            this.MainMenuStrip = this._MainMenu;
            this.Name = "MainForm";
            this.Text = "Nile";
            this._MainMenu.ResumeLayout(false);
            this._MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MenuExit;
        private System.Windows.Forms.ToolStripMenuItem _ProductAdd;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ProductEdit;
        private System.Windows.Forms.ToolStripMenuItem _ProductRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _HelpAbout;
    }
}

