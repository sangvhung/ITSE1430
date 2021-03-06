﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public static class ObjectValidator
    {
        //Validate an object and all properties
        public static IEnumerable<ValidationResult> TryValidate (this IValidatableObject source)
        {
            var context = new ValidationContext(source);
            var errors = new Collection<ValidationResult>();
            Validator.TryValidateObject(source, context, errors, true);

            return errors;
        }
        public static void Validate( this IValidatableObject source )
        {
            var context = new ValidationContext(source);
            Validator.ValidateObject(source, context, true);
        }
    }
}
