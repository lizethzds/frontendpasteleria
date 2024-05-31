using frontendnet.Models;

namespace frontendnet.Services;

public class ProductosClientServer(HttpClient client)
{
    public async Task<List<Producto>?> GetAsync(string? search)
    {
        return await client.GetFromJsonAsync<List<Producto>>($"api/productos?s={search}");
    }

    public async Task<Producto?> GetAsync(int id)
    {
        return await client.GetFromJsonAsync<Producto>($"api/productos/{id}");
    }

    public async Task<bool> PostAsync(Producto producto)
    {
        var response = await client.PostAsJsonAsync($"api/productos", producto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> PutAsync(Producto producto)
    {
        var response = await client.PutAsJsonAsync($"api/productos/{producto.ProductoId}", producto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await client.DeleteAsync($"api/productos/{id}");
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> PostAsync(int id, int categoriaid)
    {
        var response = await client.PostAsJsonAsync($"api/peliculas/{id}/categoria", new { categoriaid });
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id, int categoriaid)
    {
        var response = await client.DeleteAsync($"api/peliculas/{id}/categoria/{categoriaid}");
        return response.IsSuccessStatusCode;
    }
}