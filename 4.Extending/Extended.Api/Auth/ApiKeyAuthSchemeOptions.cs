using Microsoft.AspNetCore.Authentication;

namespace Extended.Api.Auth;

public class ApiKeyAuthSchemeOptions : AuthenticationSchemeOptions
{
    public string ApiKey { get; set; } = "VerySecret";
}
