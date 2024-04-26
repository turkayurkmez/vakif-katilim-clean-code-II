namespace CleanCode.Library
{
    public class CompanyService
    {
        private readonly IRepository<Company> _companyRepository;

        public CompanyService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Company> GetCompanies()
        {

            return _companyRepository.GetAll().ToList();
        }
    }
}
