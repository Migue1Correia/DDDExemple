using Domain.Commands;
using Domain.Enums;
using Domain.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class VeiculoService : IVeiculosService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsy(VeiculoCommand command)
        {
            if (command == null)
                throw new ArgumentNullException();


            if (command.TipoVeiculo != ETipoVeiculo.SUV 
                &&  command.TipoVeiculo != ETipoVeiculo.hatch 
                &&  command.TipoVeiculo != ETipoVeiculo.Sedan
               )


                        throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
