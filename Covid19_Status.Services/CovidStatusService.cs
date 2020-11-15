﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Covid19_Status.Models;

namespace Covid19_Status.Services
{
    public class CovidStatusService
    {
        private readonly string url = "https://api.covid19api.com/total/country/";

        public async Task<List<CovidStatus>> GetStatus(string country, DateTime from, DateTime to)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{url}{country}?from={from}&to={to}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Microsoft.AspNet.WebApi.Client => HttpContent.ReadAsAsync<T>
                    CovidStatus[] results = await response.Content.ReadAsAsync<CovidStatus[]>();

                    return results.ToList();
                }

                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
