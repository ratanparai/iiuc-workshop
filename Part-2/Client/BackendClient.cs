using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Client.Domain;

namespace Client
{
    public class BackendClient
    {
        private readonly HttpClient client;

        public BackendClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<StatusMessage>> GetAllAsync()
        {
            var response = await client.GetFromJsonAsync<List<StatusMessage>>("/Status");
            
            return response;
        }
    }
}