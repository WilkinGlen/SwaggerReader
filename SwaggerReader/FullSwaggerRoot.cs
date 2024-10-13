namespace SwaggerReader;

using System.Collections.Generic;

public class FullSwaggerRoot
{
    public string? Swagger { get; set; }
    public string? OpenApi { get; set; }
    public Info? Info { get; set; }
    public Dictionary<string, PathItem>? Paths { get; set; }
    public Dictionary<string, Schema>? Definitions { get; set; }
    public Components? Components { get; set; }
    public List<Server>? Servers { get; set; }
    public List<Tag>? Tags { get; set; }
}

public class Info
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? TermsOfService { get; set; }
    public Contact? Contact { get; set; }
    public License? License { get; set; }
    public string? Version { get; set; }
}

public class Contact
{
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
}

public class License
{
    public string? Name { get; set; }
    public string? Url { get; set; }
}

public class PathItem
{
    public Operation? Get { get; set; }
    public Operation? Post { get; set; }
    public Operation? Put { get; set; }
    public Operation? Delete { get; set; }
    public Operation? Options { get; set; }
    public Operation? Head { get; set; }
    public Operation? Patch { get; set; }
    public List<Parameter>? Parameters { get; set; }
}

public class Operation
{
    public string? Summary { get; set; }
    public string? Description { get; set; }
    public List<string>? Tags { get; set; }
    public List<Parameter>? Parameters { get; set; }
    public RequestBody? RequestBody { get; set; }
    public Dictionary<string, Response>? Responses { get; set; }
    public ExternalDocumentation? ExternalDocs { get; set; }
    public bool Deprecated { get; set; }
    public Dictionary<string, Callback>? Callbacks { get; set; }
}

public class Parameter
{
    public string? Name { get; set; }
    public string? In { get; set; }
    public string? Description { get; set; }
    public bool Required { get; set; }
    public bool Deprecated { get; set; }
    public string? Type { get; set; }
    public string? Format { get; set; }
    public Schema? Schema { get; set; }
    public List<string>? Enum { get; set; }
}

public class RequestBody
{
    public string? Description { get; set; }
    public Dictionary<string, MediaType>? Content { get; set; }
    public bool Required { get; set; }
}

public class Response
{
    public string? Description { get; set; }
    public Dictionary<string, MediaType>? Content { get; set; }
    public Dictionary<string, Header>? Headers { get; set; }
    public object? Example { get; set; }
    public Dictionary<string, object>? Examples { get; set; }
    public Dictionary<string, Link>? Links { get; set; }
}

public class MediaType
{
    public Schema? Schema { get; set; }
    public Dictionary<string, object>? Examples { get; set; }
    public object? Example { get; set; }
}

public class Schema
{
    public string? Type { get; set; }
    public string? Format { get; set; }
    public Dictionary<string, Schema>? Properties { get; set; }
    public List<string>? Required { get; set; }
    public Schema? Items { get; set; }
    public string? Ref { get; set; }
    public string? Description { get; set; }
    public List<object>? Enum { get; set; }
    public Xml? Xml { get; set; }
    public object? Default { get; set; }
}

public class Header
{
    public string? Description { get; set; }
    public Schema? Schema { get; set; }
    public bool Required { get; set; }
    public string? Example { get; set; }
}

public class Link
{
    public string? OperationId { get; set; }
    public string? Description { get; set; }
    public Dictionary<string, object>? Parameters { get; set; }
}

public class Callback
{
    public Dictionary<string, PathItem>? Urls { get; set; }
}

public class ExternalDocumentation
{
    public string? Description { get; set; }
    public string? Url { get; set; }
}

public class Components
{
    public Dictionary<string, Schema>? Schemas { get; set; }
    public Dictionary<string, SecurityScheme>? SecuritySchemes { get; set; }
    public Dictionary<string, Parameter>? Parameters { get; set; }
    public Dictionary<string, Response>? Responses { get; set; }
    public Dictionary<string, Callback>? Callbacks { get; set; }
}

public class SecurityScheme
{
    public string? Type { get; set; }
    public string? Name { get; set; }
    public string? In { get; set; }
    public string? Scheme { get; set; }
    public string? BearerFormat { get; set; }
    public OAuthFlows? Flows { get; set; }
}

public class OAuthFlows
{
    public OAuthFlow? AuthorizationCode { get; set; }
    public OAuthFlow? ClientCredentials { get; set; }
    public OAuthFlow? Implicit { get; set; }
    public OAuthFlow? Password { get; set; }
}

public class OAuthFlow
{
    public string? AuthorizationUrl { get; set; }
    public string? TokenUrl { get; set; }
    public Dictionary<string, string>? Scopes { get; set; }
}

public class Server
{
    public string? Url { get; set; }
    public string? Description { get; set; }
    public Dictionary<string, string>? Variables { get; set; }
}

public class Tag
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ExternalDocumentation? ExternalDocs { get; set; }
}

public class Xml
{
    public string? Name { get; set; }
    public bool Attribute { get; set; }
    public bool Wrapped { get; set; }
}
