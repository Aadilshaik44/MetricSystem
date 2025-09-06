using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureValueModel
    {
        [Required(ErrorMessage = "Fahrenheit Value is reuired.")]
        [Range(1, 500, ErrorMessage =
               "Fahrenheit value must be between -500 and 500.")]
        public decimal? FahrenheitValue { get; set; }

        public decimal? CalculateCelsiusValue()
      {
            if (!FahrenheitValue.HasValue) 
                return null;

            return (FahrenheitValue - 32) / 1.8M;
        }
    }
}