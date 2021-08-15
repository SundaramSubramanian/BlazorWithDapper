using DapperSample.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperSample.IServices
{
    public interface ISalesService
    {
        Task<IEnumerable<SalesDto>> GetSales();
        Task<bool> SaveSalesDetails(SalesDto sales);
        Task<SalesDto> GetSalesById(int id);
        Task<bool> DeleteSales(int id);

    }
}
