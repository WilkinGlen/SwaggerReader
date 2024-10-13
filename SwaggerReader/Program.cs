// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SwaggerReader;

Console.WriteLine("Hello, World!");

var swaggerJsonPath = "https://petstore.swagger.io/v2/swagger.json";
string swaggerJson;

if (File.Exists(swaggerJsonPath))
{
    swaggerJson = File.ReadAllText(swaggerJsonPath);
}
else
{
    // If you want to fetch it from a server endpoint
    using var httpClient = new HttpClient();
    swaggerJson = await httpClient.GetStringAsync(swaggerJsonPath);
}

var swaggerRoot = JsonConvert.DeserializeObject<FullSwaggerRoot>(swaggerJson);

Console.WriteLine($"Swagger parsed. {swaggerRoot?.Paths?.Count} paths found.");
if(swaggerRoot?.Paths?.Count > 0)
{
    foreach (var path in swaggerRoot.Paths)
    {
        Console.WriteLine(path.Key);
    }
}
