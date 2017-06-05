using CartolinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolinApp.Services
{
    public interface ICartolaApiService
    {
        Task<List<MaisEscalados>> GetMaisEscalados();
    }
}
