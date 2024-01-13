using Domain.Commands;
using Domain.Enums;
using Domain.Interfaces;
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

        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }


        public async Task <string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os campos são Obrigatorios";

            int anoatual = DateTime.Now.Year;
            if ((anoatual - command.AnoFabricado) < 5)
                return "Ano de fabricação não permitido";

            if (command.AnoFabricado > anoatual )
            return "Ano de fabricação não permitido";


            if (command.TipoVeiculo != ETipoVeiculo.SUV
                && command.TipoVeiculo != ETipoVeiculo.hatch
                && command.TipoVeiculo != ETipoVeiculo.Sedan
               )

                return "O Tipo de Veículo não pe permitido";

            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
       

        public Task<IEnumerable<VeiculoCommand>> GetVeiculoAlugadosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveisAsynk()
        {
            throw new NotImplementedException();
        }
    }
}    

