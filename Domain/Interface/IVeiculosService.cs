using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NovaPasta
{
    public interface IVeiculosService
    {
        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculoAlugadosAsync();

        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveisAsynk();
    }
}
