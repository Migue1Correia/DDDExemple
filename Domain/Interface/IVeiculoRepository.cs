﻿using Domain.Commands;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();

        Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugados();


    }

}
