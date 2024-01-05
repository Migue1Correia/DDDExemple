using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NovaPasta
{
    public interface IVeiculosService
    {
        Task PostAsy(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
    }
}
