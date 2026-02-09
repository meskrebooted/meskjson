using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meskjson
{
        public class previsioni
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string Summary { get; set; }

            public previsioni()
            {
            }

            public previsioni(DateTimeOffset date, int temperatureCelsius, string summary)
            {
                Date = date;
                TemperatureCelsius = temperatureCelsius;
                Summary = summary;
            }

            public override string ToString()
            {
                return $"{Date.ToString("dd/MM/yyyy")} - {TemperatureCelsius}°C - {Summary}";
            }
        }
}
