using System;
namespace AlDataLib.DataGenerator
{
    public class RandomGenOptions
    {
        public RandomGenStringOptions StringOptions { get; set; } = new RandomGenStringOptions();

        public RandomGenIntegerOptions IntegerOptions { get; set; } = new RandomGenIntegerOptions();

        public RandomGenDateTimeOptions DateTimeOptions { get; set; } = new RandomGenDateTimeOptions();

        public RandomGenDecimalOptions DecimalOptions { get; set; } = new RandomGenDecimalOptions();

        public RandomGenOptions()
        {
        }
    }

    public class RandomGenStringOptions
    {
        /// <summary>
        /// Gets or sets the minimum length of the generated string. Default value is zero.
        /// </summary>
        public int MinLength { get; set; } = 0;

        /// <summary>
        /// Gets or sets the maximum length of the generated string. Default value is 100.
        /// </summary>
        public int MaxLength { get; set; } = 100;

        /// <summary>
        /// Gets or sets the set of characters that consist of the generated string. Default value includes all letters a-z, A-Z, and numbers 0-9, plus '-' (dash) and '_' (underscore).
        /// </summary>
        public string CharacterSet { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";

        /// <summary>
        /// Gets or sets the word separator. Empty separator means no word separation. Default value is the SPACE character.
        /// </summary>
        public string WordSeparator { get; set; } = " ";
    }

    public class RandomGenIntegerOptions
    {
        /// <summary>
        /// Gets or sets the minimum value of the generated integer. Default value is zero.
        /// </summary>
        public int MinValue { get; set; } = 0;

        /// <summary>
        /// Gets or sets the maximum value of the generated integer. Default value is int.MaxValue.
        /// </summary>
        public int MaxValue { get; set; } = int.MaxValue;
    }

    public class RandomGenDateTimeOptions
    {
        /// <summary>
        /// Gets or sets the minimum value of the generated DateTime object. Default value is DateTime.MinValue.
        /// </summary>
        public DateTime MinValue { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Gets or sets the maximum value of the generated DateTime object. Default value is DateTime.MaxValue.
        /// </summary>
        public DateTime MaxValue { get; set; } = DateTime.MaxValue;
    }

    public class RandomGenDecimalOptions
    {
        /// <summary>
        /// Gets or sets the minimum value of the generated decimal. Default value is zero.
        /// </summary>
        public decimal MinValue { get; set; } = 0;

        /// <summary>
        /// Gets or sets the maximum value of the generated decimal. Default value is decimal.MaxValue.
        /// </summary>
        public decimal MaxValue { get; set; } = decimal.MaxValue;
    }
}
