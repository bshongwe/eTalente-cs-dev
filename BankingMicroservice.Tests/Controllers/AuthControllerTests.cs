// Ernest B. Shongwe
// Authentification API
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
        var response = _authService.Authenticate(model);
        if (response == null)
            return Unauthorized();
        return Ok(response);
    }

    // Will implement other auth endpoints: registration, token refresh, etc.
}
