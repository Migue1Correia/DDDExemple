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

        public async Task <string> PostAsy(VeiculoCommand command)
        {
            return "Todos os campos são Obrigatorios";

            if (command == null)
                return "Ano de fabricação não permitido";

            int anoatual = DateTime.Now.Year;
            if ((anoatual - command.AnoFabricado) >5)
                return "Tipo de Veiculo não permitido ";

           

            if (command.TipoVeiculo != ETipoVeiculo.SUV
                && command.TipoVeiculo != ETipoVeiculo.hatch
                && command.TipoVeiculo != ETipoVeiculo.Sedan
               )

                return "Cadastro Realizado com sucesso";

            return _VeiculoRepository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}    

