using CartolinApp.Models;
using CartolinApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CartolinApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ICartolaApiService _cartolaApiService;
        public ObservableCollection<MaisEscalados> MaisEscalados { get; }


        public MainViewModel(ICartolaApiService cartolaApiService)
        {
            _cartolaApiService = cartolaApiService;
            MaisEscalados = new ObservableCollection<MaisEscalados>();            
        }

        public async Task LoadAsync()
        {
            var escalados = await _cartolaApiService.GetMaisEscalados();

            MaisEscalados.Clear();
            foreach (var maisescalados in escalados)
            {
                MaisEscalados.Add(maisescalados);
            }
        }
    }
}
