using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users"),
        };
    }

    // Fetch all posts
    public async Task<List<T>> GetAllPostsAsync<T>(string endpoint)
    {
        return await _httpClient.GetFromJsonAsync<List<T>>(endpoint);
    }

    public async Task<T> GetAsync<T>(string endpoint, int id)
    {
        return await _httpClient.GetFromJsonAsync<T>($"{endpoint}/{id}");
    }

    // Add a new post
    public async Task<T?> AddPostAsync<T>(T post)
    {
        var response = await _httpClient.PostAsJsonAsync("posts", post);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<T>();
        }
        return default;
    }

    // Update an existing post
    public async Task<bool> UpdatePostAsync<T>(string endpoint, int id, T item)
    {
        var response = await _httpClient.PutAsJsonAsync($"{endpoint}/{id}", item);
        return response.IsSuccessStatusCode;
    }

    // Delete a post
    public async Task<bool> DeletePostAsync(string endpoint, int id)
    {
        var response = await _httpClient.DeleteAsync($"{endpoint}/{id}");
        return response.IsSuccessStatusCode;
    }
}
