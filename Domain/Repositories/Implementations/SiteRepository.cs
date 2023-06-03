namespace Domain.Repositories.Implementations;

public class SiteRepository : ARepository<Site>, ISiteRepository
{
    public SiteRepository(ModelDbContext context) : base(context)
    {
    }
}