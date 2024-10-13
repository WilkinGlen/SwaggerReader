// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerReader;

Console.WriteLine("Hello, World!");

var swaggerJsonPath = "https://petstore.swagger.io/v2/swagger.json"; // Local file path or URL
string swaggerJson;

if (File.Exists(swaggerJsonPath)) // If it's a local file
{
    swaggerJson = File.ReadAllText(swaggerJsonPath);
}
else
{
    // If you want to fetch it from a server endpoint
    using var httpClient = new HttpClient();
    swaggerJson = await httpClient.GetStringAsync(swaggerJsonPath);
}

var _ = JsonConvert.DeserializeObject<SwaggerRoot>(swaggerJson);

var swaggerDoc = JObject.Parse(swaggerJson);

// Extract the 'paths' section
var paths = swaggerDoc["paths"];

if (paths != null)
{
    foreach (var path in paths.Children<JProperty>())
    {
        Console.WriteLine($"Endpoint: {path.Name}");
        foreach (var method in path.Value.Children<JProperty>())
        {
            var httpMethod = method.Name;
            Console.WriteLine($"  Method: {httpMethod.ToUpper()}");
        }
    }
}
else
{
    Console.WriteLine("No paths found in the Swagger file.");
}
