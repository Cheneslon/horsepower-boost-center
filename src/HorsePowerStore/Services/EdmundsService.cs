using HorsePowerStore.ServiceSettings;
using HorsePowerStore.ViewModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class EdmundsService
    {
        private HttpClient client = new HttpClient();
        private EdmundsSettings settings;
        private Dictionary<string, JObject> cache = new Dictionary<string, JObject>();

        public EdmundsService(IOptions<EdmundsSettings> settings) {
            this.settings = settings.Value;

            client.BaseAddress = new Uri("https://api.edmunds.com/api/vehicle/v2/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string EdmundsUrl (string baseUrl)
        {
            return baseUrl + "?fmt=json&api_key=" + settings.EdmundsApiKey;
        }

        private async Task<JObject> GetResource (string path)
        {
            if (cache.ContainsKey(path)) return cache[path];

            HttpResponseMessage response = await client.GetAsync(EdmundsUrl(path));

            if (response.IsSuccessStatusCode)
                return
                    await response.Content.ReadAsStringAsync()
                    .ContinueWith(task =>
                    {
                        cache[path] = JObject.Parse(task.Result);
                        return cache[path];
                    });
            else throw new Exception();
        }

        public async Task<IEnumerable<string>> ListMakes ()
        {
            var makes = await GetResource("makes");
            return makes["makes"].Select(m => m["name"].ToString());
        }

        public async Task<IEnumerable<string>> ListMakeModels(string makeName)
        {
            var makes = await GetResource("makes");
            return (
                from m in makes["makes"]
                from mo in m["models"]
                where m["name"].ToString() == makeName
                select mo["name"].ToString()
                ).ToList();
        }

        public async Task<IEnumerable<int>> ListModelYears(string modelName)
        {
            var makes = await GetResource("makes");

            return (
                from m in makes["makes"]
                from mo in m["models"]
                from y in mo["years"]
                where mo["name"].ToString() == modelName
                select int.Parse(y["year"].ToString())
                ).ToList();
        }

        public async Task<StylesViewModel> GetStyles(string makeName, string modelName, int year)
        {
            if (year < 1990) return new StylesViewModel
            {
                Styles = new List<StyleViewModel>()
            };

            var trims = await GetResource(makeName + "/" + modelName + "/" + year);

            return new StylesViewModel
            {
                Styles = (
                    from s in trims["styles"]
                    select new StyleViewModel
                    {
                        Id = int.Parse(s["id"].ToString()),
                        Make = makeName,
                        Year = year,
                        Name = s["name"].ToString()
                    }
                ).ToList()
            };
        }
    }
}
