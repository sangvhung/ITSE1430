using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile
{
    public partial class ProductDetailForm : Form
    {
        //public abstract DialogResult ShowDialogEx();
              
        //public virtual DialogResult ShowDialogEx()
        //{
        //    return ShowDialog();
        //}
        protected override void OnLoad( EventArgs e )
        {
            //important logic to load product; if no product form doesnt load
            base.OnLoad(e);

            if (Product != null)
            { 
            //Load Product
            _txtName.Text = Product.Name;
            _TxtDescription.Text = Product.Description;
            _TxtPrice.Text = Product.Price.ToString();
            _CheckisDiscontinued.Checked = Product.isDiscontinued;
            };

            ValidateChildren();
        }


        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public ProductDetailForm(string title) : this() //: base()
        {
            //InitializeComponent();

            Text = title;
        }

        public ProductDetailForm( Product product ) : this("Edit Product")
        {
            //InitializeComponent();
            //Text = "Edit Product";
            Product = product;
        }

        private void ProductDetailForm_Load( object sender, EventArgs e )
        {

        }

        private void _textPrice_TextChanged( object sender, EventArgs e )
        {

        }

        private void OnCancel( object sender, EventArgs e )
        {
            
            //Cancel button to close; There a cancel when click on dialog
        }
        public Product Product { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            //Create Product
            var product = new Product();
            product.Name = _txtName.Text;
            product.Description = _textDescription.Text;
            product.Price = ConvertToPrice(_textPrice);
            product.isDiscontinued = _CheckisDiscontinued.Checked;

            var message = product.Validate();
            if (!String.IsNullOrEmpty(message))
             {
                //   _errorProvider.SetError(_txtName, message);
                DisplayError(message);
            return;
             };
           // }else
           // _errorProvider.SetError(_txtName, "");

            //return from form
            Product = product;
            DialogResult = DialogResult.OK;
            //DialogResult = DialogResult.None;
            Close();
            //Save button to close logic
        }
        private void DisplayError(string message)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private decimal ConvertToPrice (TextBox control)
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }

        

        private void _textPrice_Validating( object sender, CancelEventArgs e )
        {
            var textBox = sender as TextBox;
            var price = ConvertToPrice(textBox);
            if (price < 0)
            {
                _errorProvider.SetError(textBox, "Price must be >=0");
                e.Cancel = true;

            } else
                _errorProvider.SetError(textBox, "");
        }

        private void _Name_Validating( object sender, CancelEventArgs e )
        {
            var textBox = sender as TextBox;

            if (String.IsNullOrEmpty(textBox.Text))
            {
               _errorProvider.SetError(textBox, "Name is Required");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textBox, "");

        } 

        }
    }

