using Dapper;
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
        private string stringconnectin = "";
        public async Task<string> PostAsync(Veiculo command) 
        {
            string queryInsert = @"insert into Veiculo(Placa,AnoFabricado,ETipoVeiculo,Estado,EMontadora)\r\nValues (@Placa,@AnoFabricado, @ETipoVeiculo,@Estado, @EMontadora)"

            using (var conn = new SqlConnection()) 
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
    }
}
