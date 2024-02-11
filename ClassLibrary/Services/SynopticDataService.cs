using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WindowsAppWeatherForecast.WindowsForm.Models;
using WindowsAppWeatherForecast.WindowsForm.Services.Base;

namespace WindowsAppWeatherForecast.WindowsForm.Services
{
    public class SynopticDataService : ISynopticDataService
    {
        private readonly RestClient _restClient;
        private readonly string _baseUrl = Properties.Settings.Default.BaseUrl;
        private readonly string _synopticDataUrl = Properties.Settings.Default.SynopticDataUrl;
        private readonly string _accessUrl = Properties.Settings.Default.AccesUrl;
        private readonly string _allSynopticDataController = Properties.Settings.Default.AllSynopticDataEndpoint;
        private readonly string _townListController = Properties.Settings.Default.TownsListEndpoint;
        private readonly string _townSynopticDataController = Properties.Settings.Default.AllDataTownEndpoint;
        private readonly string _townsSynopticDataController = Properties.Settings.Default.AllDataTownsEndpoint;
        private readonly string _townsTemperaturesController = Properties.Settings.Default.TownsTemperaturesEndpoint;
        private readonly string _townsPressuresController = Properties.Settings.Default.TownsPressuresEndpoint;
        private readonly string _townsHumiditiesController = Properties.Settings.Default.TownsHumiditiesEndpoint;
        private readonly string _serverStatusController = Properties.Settings.Default.ServerStatusEndpoint;
        private readonly string _pingController = Properties.Settings.Default.ServerPingEndpoint;
        private readonly string _messagePingError = Properties.Settings.Default.MessagePingError;
        private readonly string _messageAvibilityError = Properties.Settings.Default.MessageAvibilityError;
        private readonly string _messageServerNotResponse = Properties.Settings.Default.MessageServerNotResponse;
        private readonly string _messageGetSynopticDataError = Properties.Settings.Default.MessageGetSynopticDataError;
        private readonly string _messageDataDeserializationError = Properties.Settings.Default.MessageDataDeserializationError;


        public SynopticDataService()
        {
            _restClient = new RestClient(_baseUrl);
        }

        public StatusResponseEntry CheckPing()
        {
            var request = new RestRequest($"{_baseUrl}{_accessUrl}{_pingController}", Method.Get);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            try
            {
                var result = _restClient.Execute<StatusResponseEntry>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var statusResponse = JsonConvert.DeserializeObject<StatusResponseEntry>(result.Content);
                    return statusResponse;
                }
                else
                {
                    Console.WriteLine($"{_messagePingError}: \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public StatusResponseEntry CheckPublicServerAvibility()
        {
            var request = new RestRequest($"{_baseUrl}{_accessUrl}{_serverStatusController}", Method.Get);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            try
            {
                var result = _restClient.Execute<StatusResponseEntry>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var statusResponse  = JsonConvert.DeserializeObject<StatusResponseEntry>(result.Content);
                    return statusResponse;
                }
                else
                {
                    Console.WriteLine($"{_messageAvibilityError}: \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }


        public List<SynopticDataEntry> GetListOfSynopticDataForAllTowns()
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_allSynopticDataController}", Method.Get);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            try
            {
                var result = _restClient.Execute<List<SynopticDataEntry>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var synopticDataList = System.Text.Json.JsonSerializer.Deserialize<List<SynopticDataEntry>>(result.Content);
                    return synopticDataList;
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public SynopticDataEntry GetSynopticDataForOneTown(string unnormalizedName)
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townSynopticDataController}", Method.Get);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            request.AddParameter("unnormalizedName", unnormalizedName);
            try
            {
                var result = _restClient.Execute<SynopticDataEntry>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var synopticData = System.Text.Json.JsonSerializer.Deserialize<SynopticDataEntry>(result.Content);
                    return synopticData;
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<SynopticDataEntry> GetListOfSynopticDataForTowns(List<string> names)
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townsSynopticDataController}", Method.Post);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            request.AddJsonBody(names);
            try
            {
                var result = _restClient.Execute<List<SynopticDataEntry>>(request);

                if (result.IsSuccessful)
                {
                    if (!string.IsNullOrEmpty(result.Content))
                    {
                        var synopticDataList = System.Text.Json.JsonSerializer.Deserialize<List<SynopticDataEntry>>(result.Content);
                        return synopticDataList;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<TemperatureDataEntry> GetListOfTemperatureDataForTowns(List<string> names)
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townsTemperaturesController}", Method.Post);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            request.AddJsonBody(names);
            try
            {
                var result = _restClient.Execute<List<TemperatureDataEntry>>(request);
                if (result.IsSuccessful && !string.IsNullOrEmpty(result.Content))
                {
                    var townsTemperaturesList = JsonConvert.DeserializeObject<List<TemperatureDataEntry>>(result.Content);

                    if (townsTemperaturesList[0].Nazwa != null)
                    {
                        return townsTemperaturesList;
                    }
                    else
                    {
                        Debug.WriteLine(_messageDataDeserializationError);
                    }
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<HumidityDataEntry> GetListOfHumidityDataForTowns(List<string> names)
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townsHumiditiesController}", Method.Post);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            request.AddJsonBody(names);
            try
            {
                var result = _restClient.Execute<List<HumidityDataEntry>>(request);
                if (result.IsSuccessful && !string.IsNullOrEmpty(result.Content))
                {
                    var townsHumiditiesList = JsonConvert.DeserializeObject<List<HumidityDataEntry>>(result.Content);
                    if (townsHumiditiesList[0].Nazwa != null)
                    {
                        return townsHumiditiesList;
                    }
                    else
                    {
                        Debug.WriteLine(_messageDataDeserializationError);
                    }
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<PressureDataEntry> GetListOfPressureDataForTowns(List<string> names)
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townsPressuresController}", Method.Post);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            request.AddJsonBody(names);
            try
            {
                var result = _restClient.Execute<List<PressureDataEntry>>(request);
                if (result.IsSuccessful && !string.IsNullOrEmpty(result.Content))
                {
                    var townsPressuresList = JsonConvert.DeserializeObject<List<PressureDataEntry>>(result.Content);

                    if (townsPressuresList[0].Nazwa != null)
                    {
                        return townsPressuresList;
                    }
                    else
                    {
                        Debug.WriteLine(_messageDataDeserializationError);
                    }
                }
                else
                {
                    Console.WriteLine($"{_messageGetSynopticDataError}:  \nErrorMessage: {result.ErrorMessage} \nContent: {result.Content} \nErrorException: {result.ErrorException}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }

        public List<string> GetTownsList()
        {
            var request = new RestRequest($"{_baseUrl}{_synopticDataUrl}{_townListController}", Method.Get);
            request.AddHeader("client-token", Properties.Settings.Default.ClientToken);
            try
            {
                var result = _restClient.Execute<List<string>>(request);
                if (result.IsSuccessful && result.Content != null)
                {
                    var townsList = System.Text.Json.JsonSerializer.Deserialize<List<string>>(result.Content);
                    return townsList;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return null;
        }
    }
}
