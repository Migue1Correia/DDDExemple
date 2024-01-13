using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
      
            string conexao = @"insert into Veiculo(Placa,AnoFabricado,E )\r\nValues (@Placa,@AnoFabricado, @ETipoVeiculo,@Estado, @EMontadora)";
            public async Task<string> PostAsync(VeiculoCommand command)
            {

            string queryInsert = @" 
                Insert Into Veiculo(Placa,AnoFabricado,ETipoVeiculo,Estado,EMontadora)
                Volues (@Placa,@AnoFabricado, @ETipoVeiculo,@Estado, @EMontadora)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {


                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricado = command.AnoFabricado,
                    ETipoVeiculo = command.TipoVeiculo,
                    Estado = command.Estado,
                    EMontadora = command.Montadora

                });

                return "veiculo cadastrado com sucesso";
            }
        }
        public void PostAsync() 
        {

        }

        public void GetAsync() 
        {
        
        }

        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis()
        {
            string queryBuscarVeiculosDisponiveis = @"SELECT * FROM Veiculo WHARE Alugado = 0";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosDisponiveis).Result.ToList();
            }
        }

            public async Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugados()
        { 
            string queryBuscarVeiculosAlugados = @"SELECT * FROM Veiculo WHARE Alugado = 1";
            using (SqlConnection conn = new SqlConnection(conexao)) 
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosAlugados).Result.ToList();
            }

        }

    }
}
