/*
 * ITSE 1430 Lab3
 * Sang Hung
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Represents a movie.</summary>
    public class Movie : IValidatableObject
    {
        public int Id { get; set; }
        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }

        /// <summary>Determines if the movie is owned or not.</summary>
        public bool IsOwned { get; set; }

        /// <summary>Gets or sets the length, in minutes.</summary>
        public int Length { get; set; }

        /// <summary>Gets or sets the title.</summary>
        public string Title
        {
            get { return _title ?? ""; }
            set { _title = value; }
        }
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            //Title is required
            if (String.IsNullOrEmpty(_title))
                errors.Add(new ValidationResult("Title cannot be empty",
                    new[] { nameof(Title) }));

            //Length >= 0
            if (Length < 0)
                errors.Add(new ValidationResult("Length must be >= 0",
                    new[] { nameof(Length) }));

            return errors;
        }

        #region Private Members

        private string _title, _description;
        
        #endregion
    }
}
