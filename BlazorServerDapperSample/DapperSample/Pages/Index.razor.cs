using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperSample.IServices;
using DapperSample.Data;
using DapperSample.Services;
using Microsoft.AspNetCore.Components;

namespace DapperSample.Pages
{
    public partial class Index
    {
        IEnumerable<SalesDto> salesEntries;
        [Inject]
        public ISalesService SalesServices { get; set; }
        SalesDto sales = new SalesDto();

        protected override async Task OnInitializedAsync()
        {
            await this.GetSalesDetails();
        }
        protected async Task GetSalesDetails()
        {
            salesEntries = await SalesServices.GetSales();
        }

        protected async Task CreateSales()
        {
            await SalesServices.SaveSalesDetails(sales);
            await this.GetSalesDetails();
            this.ClearAll();
        }
        protected async Task UpdateSales()
        {
            await SalesServices.SaveSalesDetails(sales);
            await this.GetSalesDetails();
            this.ClearAll();
        }
        protected async Task GetSalesById(int SalesId)
        {
            sales = await SalesServices.GetSalesById(SalesId);
            sales.IsUpdate = true;
            await this.GetSalesDetails();
        }
        protected async Task DeleteSales(int SalesId)
        {
            await SalesServices.DeleteSales(SalesId);
            await this.GetSalesDetails();
        }
        public void ClearAll()
        {
            sales.ProductName = string.Empty;
            sales.Quantity = 0;
        }
    }
}
