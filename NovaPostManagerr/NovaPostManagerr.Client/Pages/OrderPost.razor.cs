using Core.Dto;
using Core.Interface;
using Microsoft.AspNetCore.Components;

namespace NovaPostManagerr.Client.Pages
{
    public partial class OrderPost : ComponentBase
    {
        [Inject] public IOrderPostService OrderPostService { get; set; }
        private ICollection<OrderModel> _items;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadData(); // Загрузка данных при инициализации компонента
        }

        protected async Task LoadData()
        {
            try
            {
                StateHasChanged(); // Обновление UI для отображения индикатора загрузки

                _items = await OrderPostService.GetOrders();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }
    }
}