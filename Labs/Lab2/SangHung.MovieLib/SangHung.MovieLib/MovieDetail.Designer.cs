namespace SangHung.MovieLib
{
    partial class MovieDetailForm
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
            this._TxtTitle = new System.Windows.Forms.Label();
            this._TxtDescription = new System.Windows.Forms.Label();
            this._TxtLength = new System.Windows.Forms.Label();
            this._Title = new System.Windows.Forms.TextBox();
            this._Description = new System.Windows.Forms.TextBox();
            this._Length = new System.Windows.Forms.TextBox();
            this._ChkOwned = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _TxtTitle
            // 
            this._TxtTitle.AutoSize = true;
            this._TxtTitle.Location = new System.Drawing.Point(46, 34);
            this._TxtTitle.Name = "_TxtTitle";
            this._TxtTitle.Size = new System.Drawing.Size(27, 13);
            this._TxtTitle.TabIndex = 0;
            this._TxtTitle.Text = "Title";
            // 
            // _TxtDescription
            // 
            this._TxtDescription.AutoSize = true;
            this._TxtDescription.Location = new System.Drawing.Point(13, 57);
            this._TxtDescription.Name = "_TxtDescription";
            this._TxtDescription.Size = new System.Drawing.Size(60, 13);
            this._TxtDescription.TabIndex = 1;
            this._TxtDescription.Text = "Description";
            // 
            // _TxtLength
            // 
            this._TxtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._TxtLength.AutoSize = true;
            this._TxtLength.Location = new System.Drawing.Point(33, 152);
            this._TxtLength.Name = "_TxtLength";
            this._TxtLength.Size = new System.Drawing.Size(40, 13);
            this._TxtLength.TabIndex = 2;
            this._TxtLength.Text = "Length";
            // 
            // _Title
            // 
            this._Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Title.Location = new System.Drawing.Point(79, 31);
            this._Title.Name = "_Title";
            this._Title.Size = new System.Drawing.Size(343, 20);
            this._Title.TabIndex = 3;
            // 
            // _Description
            // 
            this._Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Description.Location = new System.Drawing.Point(79, 57);
            this._Description.Multiline = true;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(343, 86);
            this._Description.TabIndex = 4;
            // 
            // _Length
            // 
            this._Length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._Length.Location = new System.Drawing.Point(79, 149);
            this._Length.Name = "_Length";
            this._Length.Size = new System.Drawing.Size(60, 20);
            this._Length.TabIndex = 5;
            // 
            // _ChkOwned
            // 
            this._ChkOwned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._ChkOwned.AutoSize = true;
            this._ChkOwned.Location = new System.Drawing.Point(79, 175);
            this._ChkOwned.Name = "_ChkOwned";
            this._ChkOwned.Size = new System.Drawing.Size(60, 17);
            this._ChkOwned.TabIndex = 6;
            this._ChkOwned.Text = "Owned";
            this._ChkOwned.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "minutes";
            // 
            // _buttonSave
            // 
            this._buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSave.Location = new System.Drawing.Point(266, 218);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 8;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(347, 218);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 9;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 253);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._ChkOwned);
            this.Controls.Add(this._Length);
            this.Controls.Add(this._Description);
            this.Controls.Add(this._Title);
            this.Controls.Add(this._TxtLength);
            this.Controls.Add(this._TxtDescription);
            this.Controls.Add(this._TxtTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _TxtTitle;
        private System.Windows.Forms.Label _TxtDescription;
        private System.Windows.Forms.Label _TxtLength;
        private System.Windows.Forms.TextBox _Title;
        private System.Windows.Forms.TextBox _Description;
        private System.Windows.Forms.TextBox _Length;
        private System.Windows.Forms.CheckBox _ChkOwned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
    }
}