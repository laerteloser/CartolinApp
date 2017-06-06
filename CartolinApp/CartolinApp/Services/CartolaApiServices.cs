using CartolinApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(CartolinApp.Services.CartolaApiServices))]
namespace CartolinApp.Services
{
    public class CartolaApiServices : ICartolaApiService
    {
        private const string BaseUrl = "https://api.cartolafc.globo.com/";

        public async Task<List<MaisEscalados>> GetMaisEscalados()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var response = await httpClient.GetAsync($"{BaseUrl}mercado/destaques").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        return JsonConvert.DeserializeObject<List<MaisEscalados>>(
                            await new StreamReader(responseStream)
                                .ReadToEndAsync().ConfigureAwait(false));
                    }
                }
            }
            catch (HttpRequestException e)
            {
                e.Message.ToString();               
                return null;
            }
            return null;
        }

        public async Task<List<Jogadores>> GetDadosJogador()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var response = await httpClient.GetAsync($"{BaseUrl}atletas/mercado").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        return JsonConvert.DeserializeObject<List<Jogadores>>(
                            await new StreamReader(responseStream)
                                .ReadToEndAsync().ConfigureAwait(false));
                    }
                }
            }
            catch (HttpRequestException e)
            {
                e.Message.ToString();
                return null;
            }
            return null;
        }
    }
}