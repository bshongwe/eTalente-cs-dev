// Ernest B. Shongwe
// API Endpoints
[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly AccountRepository _accountRepository;
    private readonly AuthService _authService;
    private readonly AuditTrailRepository _auditTrailRepository;

    public AccountController(AccountRepository accountRepository, AuthService authService, AuditTrailRepository auditTrailRepository)
    {
        _accountRepository = accountRepository;
        _authService = authService;
        _auditTrailRepository = auditTrailRepository;
    }

    [HttpGet("{id}")]
    public ActionResult<Account> GetAccount(int id)
    {
        var account = _accountRepository.GetAccountById(id);
        if (account == null)
            return NotFound();
        return Ok(account);
    }

    // Will implement other endpoints for retrieving account lists and creating withdrawals
}
