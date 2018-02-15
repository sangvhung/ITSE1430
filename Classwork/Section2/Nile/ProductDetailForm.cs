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
        public ProductDetailForm()
        {
            InitializeComponent();
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

            //Create Product
            var product = new Product();
            product.Name = _txtName.Text;
            product.Description = _textDescription.Text;
            product.Price = ConvertToPrice(_textPrice);
            Product.isDiscontinued = _CheckisDiscontinued.Checked;

            //return from form
            Product = product;
            DialogResult = DialogResult.OK;
            //DialogResult = DialogResult.None;
            Close();
            //Save button to close
        }

        private decimal ConvertToPrice (TextBox control)
        {
            if (Decimal.TryParse(Control.Text, out var price))
                return price;

            return -1;
        }
    }
}
