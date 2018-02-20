namespace Nile
{
    partial class ProductDetailForm
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
            this._textName = new System.Windows.Forms.TextBox();
            this._textDescription = new System.Windows.Forms.TextBox();
            this._textPrice = new System.Windows.Forms.TextBox();
            this._CheckisDiscontinued = new System.Windows.Forms.CheckBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._txtName = new System.Windows.Forms.Label();
            this._TxtDescription = new System.Windows.Forms.Label();
            this._TxtPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textName
            // 
            this._textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textName.Location = new System.Drawing.Point(78, 52);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(100, 20);
            this._textName.TabIndex = 0;
            // 
            // _textDescription
            // 
            this._textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textDescription.Location = new System.Drawing.Point(78, 78);
            this._textDescription.Multiline = true;
            this._textDescription.Name = "_textDescription";
            this._textDescription.Size = new System.Drawing.Size(141, 49);
            this._textDescription.TabIndex = 1;
            // 
            // _textPrice
            // 
            this._textPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._textPrice.Location = new System.Drawing.Point(78, 133);
            this._textPrice.Name = "_textPrice";
            this._textPrice.Size = new System.Drawing.Size(100, 20);
            this._textPrice.TabIndex = 2;
            this._textPrice.TextChanged += new System.EventHandler(this._textPrice_TextChanged);
            // 
            // _CheckisDiscontinued
            // 
            this._CheckisDiscontinued.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._CheckisDiscontinued.AutoSize = true;
            this._CheckisDiscontinued.Location = new System.Drawing.Point(78, 159);
            this._CheckisDiscontinued.Name = "_CheckisDiscontinued";
            this._CheckisDiscontinued.Size = new System.Drawing.Size(104, 17);
            this._CheckisDiscontinued.TabIndex = 3;
            this._CheckisDiscontinued.Text = "is Discontinued?";
            this._CheckisDiscontinued.UseVisualStyleBackColor = true;
            // 
            // _buttonSave
            // 
            this._buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSave.Location = new System.Drawing.Point(103, 196);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 4;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(184, 196);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 5;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _txtName
            // 
            this._txtName.AutoSize = true;
            this._txtName.Location = new System.Drawing.Point(37, 52);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(35, 13);
            this._txtName.TabIndex = 6;
            this._txtName.Text = "Name";
            // 
            // _TxtDescription
            // 
            this._TxtDescription.AutoSize = true;
            this._TxtDescription.Location = new System.Drawing.Point(12, 81);
            this._TxtDescription.Name = "_TxtDescription";
            this._TxtDescription.Size = new System.Drawing.Size(60, 13);
            this._TxtDescription.TabIndex = 7;
            this._TxtDescription.Text = "Description";
            // 
            // _TxtPrice
            // 
            this._TxtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._TxtPrice.AutoSize = true;
            this._TxtPrice.Location = new System.Drawing.Point(41, 136);
            this._TxtPrice.Name = "_TxtPrice";
            this._TxtPrice.Size = new System.Drawing.Size(31, 13);
            this._TxtPrice.TabIndex = 8;
            this._TxtPrice.Text = "Price";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this._TxtPrice);
            this.Controls.Add(this._TxtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._CheckisDiscontinued);
            this.Controls.Add(this._textPrice);
            this.Controls.Add(this._textDescription);
            this.Controls.Add(this._textName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 272);
            this.Name = "ProductDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textName;
        private System.Windows.Forms.TextBox _textDescription;
        private System.Windows.Forms.TextBox _textPrice;
        private System.Windows.Forms.CheckBox _CheckisDiscontinued;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Label _txtName;
        private System.Windows.Forms.Label _TxtDescription;
        private System.Windows.Forms.Label _TxtPrice;
    }
}