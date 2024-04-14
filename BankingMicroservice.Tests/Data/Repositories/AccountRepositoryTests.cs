// Ernest B. Shongwe
// Creates repositories
public class AccountRepository
{
    private readonly ApplicationDbContext _context;

    public AccountRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Account GetAccountById(int id)
    {
        return _context.Accounts.FirstOrDefault(a => a.Id == id);
    }

    // Will implement other CRUD operations
}

// AuditTrailRepository.cs
public class AuditTrailRepository
{
    private readonly ApplicationDbContext _context;

    public AuditTrailRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void LogAuditTrail(AuditTrail auditTrail)
    {
        _context.AuditTrails.Add(auditTrail);
        _context.SaveChanges();
    }
}
