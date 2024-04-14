// Ernest B. Shongwe
// DB Context
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountHolder> AccountHolders { get; set; }
}
