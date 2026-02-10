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

            private string GetWeatherIcon()
            {
                string desc = Summary.ToLower();
                if (desc.Contains("infernale") || desc.Contains("hell"))
                    return "🔥";
                if (desc.Contains("sottozero") || desc.Contains("subzero"))
                    return "🥶";
                if (desc.Contains("soleggiato") || desc.Contains("sole") || desc.Contains("sunny") || desc.Contains("clear"))
                    return "☀️";
                if (desc.Contains("nuvoloso") || desc.Contains("nuvol") || desc.Contains("cloudy") || desc.Contains("cloud") || desc.Contains("coperto") || desc.Contains("overcast"))
                    return "☁️";
                if (desc.Contains("parzial") || desc.Contains("partly") || desc.Contains("partial"))
                    return "⛅";
                if (desc.Contains("piogg") || desc.Contains("rain") || desc.Contains("drizzle"))
                    return "🌧️";
                if (desc.Contains("temporal") || desc.Contains("tuoni") || desc.Contains("storm") || desc.Contains("thunder"))
                    return "⛈️";
                if (desc.Contains("nev") || desc.Contains("snow"))
                    return "❄️";
                if (desc.Contains("nebbia") || desc.Contains("fog") || desc.Contains("mist"))
                    return "🌫️";
                if (desc.Contains("vento") || desc.Contains("vent") || desc.Contains("wind"))
                    return "💨";
                
                return "🌤️";
            }

            public override string ToString()
            {
                return $"{GetWeatherIcon()} {Date.ToString("dd/MM/yyyy")} - {TemperatureCelsius}°C - {Summary}";
            }
        }
}
