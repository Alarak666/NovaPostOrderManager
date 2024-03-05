using Core.Dto.SearchSettlement;
using Core.Interface;
using Microsoft.AspNetCore.Components;

namespace NovaPostManagerr.Client.Pages
{
    public partial class CityPage : ComponentBase
    {
        [Inject] public ISearchSettlementService SearchSettlementService { get; set; }
        private ICollection<SearchSettlementAddress> _items;
        private bool _isLoading = false;
        private bool _isFailure = false;
        private string _errorMessage = "";

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadData("Київ"); // Загрузка данных при инициализации компонента
        }

        protected async Task LoadData(string сityName)
        {
            try
            {
                _isLoading = true;
                StateHasChanged(); // Обновление UI для отображения индикатора загрузки

                var response = await SearchSettlementService.GetCityData(сityName);
                var data = response.data;
                 _items = data.SelectMany(x => x.Addresses).ToList();
                _isFailure = false;
            }
            catch (Exception ex)
            {
                _isFailure = true;
                _errorMessage = ex.Message;
            }
            finally
            {
                _isLoading = false;
            }
        }
    }
}