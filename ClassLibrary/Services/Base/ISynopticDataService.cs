using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WindowsAppWeatherForecast.WindowsForm.Models;

namespace WindowsAppWeatherForecast.WindowsForm.Services.Base
{
    public interface ISynopticDataService
    {
        StatusResponseEntry CheckPublicServerAvibility();
        StatusResponseEntry CheckPing();
        List<SynopticDataEntry> GetListOfSynopticDataForAllTowns();
        List<string> GetTownsList();
        SynopticDataEntry GetSynopticDataForOneTown(string normalizedName);
        List<SynopticDataEntry> GetListOfSynopticDataForTowns(List<string> names);
        List<TemperatureDataEntry> GetListOfTemperatureDataForTowns(List<string> names);
        List<PressureDataEntry> GetListOfPressureDataForTowns(List<string> names);
        List<HumidityDataEntry> GetListOfHumidityDataForTowns(List<string> names);
    }
}
