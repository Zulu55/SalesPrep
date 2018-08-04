namespace SalesPrep.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Domain.Models;
    using Services;

    public class ProductsViewModel
    {
        public ApiService apiService { get; set; }

        public ObservableCollection<Product> Product { get; set; }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async Task LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("", "", "");
        }
    }
}
