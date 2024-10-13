namespace SwaggerReader;
public class SwaggerRoot
{
    public string? Swagger { get; set; }
    public Info? Info { get; set; }
    public Dictionary<string, PathItem>? Paths { get; set; }
    public Components? Components { get; set; }
}

public class Info
{
    public string? Title { get; set; }
    public string? Version { get; set; }
}

public class PathItem
{
    public Operation? Get { get; set; }
    public Operation? Post { get; set; }
    public Operation? Put { get; set; }
    public Operation? Delete { get; set; }
    public Operation? Patch { get; set; }
}

public class Operation
{
    public string? Summary { get; set; }
    public List<Parameter>? Parameters { get; set; }
    public Dictionary<string, Response>? Responses { get; set; }
}

public class Parameter
{
    public string? Name { get; set; }
    public string? In { get; set; }
    public bool Required { get; set; }
    public Schema? Schema { get; set; }
}

public class Response
{
    public string? Description { get; set; }
    public Dictionary<string, MediaType>? Content { get; set; }
    public Dictionary<string, Header>? Headers { get; set; }
    public object? Example { get; set; }
    public Dictionary<string, object>? Examples { get; set; }
}

public class Header
{
    public string? Description { get; set; }
    public Schema? Schema { get; set; }
    public bool Required { get; set; }
    public string? Example { get; set; }
}

public class Components
{
    public Dictionary<string, Schema>? Schemas { get; set; }
}

public class Schema
{
    public string? Type { get; set; }
    public string? Format { get; set; }
    public Dictionary<string, Schema>? Properties { get; set; }
    public List<string>? Required { get; set; }
    public Schema? Items { get; set; }
    public string? Example { get; set; }
    public object? Default { get; set; }
}

public class Content
{
    public Dictionary<string, MediaType>? MediaTypes { get; set; }
}

public class MediaType
{
    public Schema? Schema { get; set; }
    public Dictionary<string, object>? Examples { get; set; }
    public object? Example { get; set; }
}