﻿namespace Pluralsight_Gighub.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy", CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}