using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WindowsAppWeatherForecast.WindowsForm.Models
{
    public class SynopticDataEntry
    {
        [JsonPropertyName("id_stacji")]
        public string IdStacji { get; set; }

        [JsonPropertyName("stacja")]
        public string Stacja { get; set; }

        [JsonPropertyName("data_pomiaru")]
        public string DataPomiaru { get; set; }

        [JsonPropertyName("godzina_pomiaru")]
        public string GodzinaPomiaru { get; set; }

        [JsonPropertyName("temperatura")]
        public string Temperatura { get; set; }

        [JsonPropertyName("predkosc_wiatru")]
        public string PredkoscWiatru { get; set; }

        [JsonPropertyName("kierunek_wiatru")]
        public string KierunekWiatru { get; set; }

        [JsonPropertyName("wilgotnosc_wzgledna")]
        public string WilgotnoscWzgledna { get; set; }

        [JsonPropertyName("suma_opadu")]
        public string SumaOpadu { get; set; }

        [JsonPropertyName("cisnienie")]
        public string Cisnienie { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder
                .AppendLine($"Stacja: {Stacja}".ToUpper())
                .AppendLine($"ID stacji: {IdStacji}")
                .AppendLine($"Data pomiaru: {DataPomiaru}")
                .AppendLine($"Godzina pomiaru: {GodzinaPomiaru}")
                .AppendLine($"Temperatura: {Temperatura}")
                .AppendLine($"Predkość wiatru: {PredkoscWiatru}")
                .AppendLine($"Kierunek wiatru: {KierunekWiatru}")
                .AppendLine($"Wilgotność względna: {WilgotnoscWzgledna}")
                .AppendLine($"Suma opadu: {SumaOpadu}")
                .AppendLine($"Ciśnienie: {Cisnienie}")
                .AppendLine(null);

            return stringBuilder.ToString();
        }

        public string ToStringShort()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder
                .AppendLine($"Nazwa stacji: {Stacja}")
                .AppendLine($"Data pomiaru: {DataPomiaru}")
                .AppendLine($"Godzina pomiaru: {GodzinaPomiaru}")
                .AppendLine($"Temperatura: {Temperatura}")
                .AppendLine($"Ciśnienie: {Cisnienie}")
                .AppendLine(null);

            return stringBuilder.ToString();
        }

    }
}
