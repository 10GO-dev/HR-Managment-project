using H_Resource.Models;

namespace H_Resource._Repositories
{
    public interface IPayrollRepository
    {
        Task<IEnumerable<PayrollModel?>> GetAllAsync();
        Task<IEnumerable<PayrollModel>> FindByValueAsync(string criteria, string value);
        PayrollModel? GetAsync(int id);
    }
}