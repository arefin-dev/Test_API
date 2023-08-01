using CompanyApp.Entity;

namespace CompanyApp.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
