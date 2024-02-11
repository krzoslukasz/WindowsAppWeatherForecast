using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WindowsAppWeatherForecast.WindowsForm.Models
{
    public class StatusResponseEntry
    {
        public  string StatusInformation { get; set; }
        public  string StatusCode { get; set; }

        public override string ToString()
        {
            return $"StatusInformation: {StatusInformation}, StatusCode: {StatusCode}";
        }

    }
}
