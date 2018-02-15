using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

        
        

            var product = new Product();

            Decimal.TryParse("123", out var price);
            product.Price = price;

            var name = product.Name;
            //var name = product.GetName();
            product.Name = "Product A";
            product.Price = 50;
            product.isDiscontinued = true;

            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;
            //product.SetName("Product A");

            var error = product.Validate();

            var str = product.ToString();

            var productb = new Product();
            //productb.Name = "ProductB";
            productb.SetName("Product B");
            //productb.Description = product.Description;
            error = productb.Validate();
        }

        

        private void OnProductAdd( object sender, EventArgs e )
        {
            var form = new ProductDetailForm();
            form.Text = "Add Product";

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            _product = form.Product;
        }

        private void _HelpAbout_Click( object sender, EventArgs e )
        {

        }
        
        //This code below is for knowing what the user clicks on
        private bool ShowConfirmation(string message, string title)
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        }

        private void OnProductRemove( object sender, EventArgs e )
        {
           if(!ShowConfirmation( "Are you sure?", "Remove Product")) 
             return;

            //TODO: Remove Product
            MessageBox.Show("Not Implemented");
        }
        private void OnProductEdit( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "Product Edit", MessageBoxButtons.YesNo);
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "File Exit", MessageBoxButtons.YesNo);
        }

        private Product _product;
    }

}
