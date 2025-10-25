using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenCodeERP.Model;
using System.Net.Http;
using System.Text.Json;

namespace ZenCodeERP.Utils
{
    public static class ViaCepService
    {
        public static async Task<Endereco?> BuscarEnderecoAsync(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return null;

            cep = cep.Replace("-", "").Trim();
            string url = $"https://viacep.com.br/ws/{cep}/json";

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();

                JsonDocument json = JsonDocument.Parse(responseString);

                return new Endereco
                {
                    RUA = json.RootElement.GetProperty("logradouro").GetString(),
                    BAIRRO = json.RootElement.GetProperty("bairro").GetString(),
                    CIDADE = json.RootElement.GetProperty("localidade").GetString(),
                    ESTADO = json.RootElement.GetProperty("uf").GetString(),
                    CEP = cep,
                    PAIS = "Brasil"
                };
            }
            catch
            {
                return null;
            }
        }

    }
}
