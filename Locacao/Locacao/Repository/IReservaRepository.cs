﻿using System.Collections.Generic;
using Locacao.Models;

namespace Locacao.Repository
{
    public interface IReservaRepository
    {
        List<Reserva> BuscaListaReserva();
        void SaveReserva(Reserva reserva);

        List<Reserva> BuscaListaReserva(int idUser);

        Reserva BuscaReservaId(int IdReserva);
    }
}