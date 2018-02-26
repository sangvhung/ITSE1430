using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangHung.MovieLib
{
    public class Movie
    {
    public string Title
        {
            get { return _title ?? ""; }
            set { _title = value; }
        }
    public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }
    public decimal Length
        {
            get; set;
        } = 0;
    public bool Owned
        {
            get;set;
        }
    public string GetTitle()
        {
            return _title;
        }
    /// <summary>Sets the title name.</summary>
    /// <param name="value">The Title.</param>
    public void SetTitle (string value)
        {
            _title = value ?? "";
        }
    public string Validate()
        {
            //Title is required
            if (String.IsNullOrEmpty(_title))
                return "Title cannot be empty";

            //Length >=0 if specified
            if (_length > 0)
                return "Length must be >=0";
            return "";
        }

    private string _title;
    private string _description;
    private decimal _length;
    private bool _owned;
    }

    
}
