using System;
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

        public async Task<List<StatusMessage>> PostComment(Guid statusId, string name, string comment)
        {
            var postComment = new Comment
            {
                Name = name,
                CommentText = comment,
            };
            await client.PostAsJsonAsync<Comment>("/Status/Comment/" + statusId, postComment);
            return await GetAllAsync();
        }
    }
}