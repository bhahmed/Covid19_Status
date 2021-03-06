﻿using Covid19_Status.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Status.Services
{
    public class CountryService
    {
        private readonly string url = "https://api.covid19api.com/countries";

        public async Task<List<CountryModel>> GetAllCountries()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Microsoft.AspNet.WebApi.Client => HttpContent.ReadAsAsync<T>
                    CountryModel[] results = await response.Content.ReadAsAsync<CountryModel[]>();

                    return results.ToList();
                }

                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
