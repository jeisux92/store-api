using Store.Models.DTO;
using Store.Models.Entities;
using Store.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Services.Implementation
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IBillRepository _billRepository;
        private readonly ICustomerRepository _customerRepository;

        public SaleService(ISaleRepository saleRepository, IBillRepository billRepository, ICustomerRepository customerRepository)
        {
            _saleRepository = saleRepository;
            _billRepository = billRepository;
            _customerRepository = customerRepository;
        }

        public async Task CreateSaleAsync(long customerId, Dictionary<int, int> products)
        {
            Sale sale = new Sale
            {
                CustomerId = customerId,
                Total = products.Values.Sum()

            };
            int saleId = await _saleRepository.CreateAsync(sale);

            IEnumerable<Bill> bills = products.Select(x => new Bill
            {
                SaleId = saleId,
                ProductId = x.Key,
                Quantity = x.Value
            });

            _billRepository.Create(bills);

        }

        public async Task<IEnumerable<Bill>> GetAllBillAsync(int id)
        {
            Sale sale = await GetSaleAsync(id);
            return await _billRepository.GetBySaleIdAsync(sale.Id);
        }

        public async Task<IEnumerable<SaleCustomerDto>> GetAllSaleAsync() =>
            await _saleRepository.GetAllWithCustomerAsync();


        public async Task<Sale> GetSaleAsync(int id) => await _saleRepository.GetByIdAsync(id);
    }
}
