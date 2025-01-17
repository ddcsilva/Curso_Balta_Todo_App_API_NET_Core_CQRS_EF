﻿using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTarefaRepository : ITarefaRepository
    {
        public void Inserir(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefa BuscarPorId(Guid id, string usuario)
        {
            return new Tarefa("Título da Tarefa", DateTime.Now, "danilosilva");
        }

        public IEnumerable<Tarefa> RetornarTodas(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tarefa> RetornarTodasConcluidas(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tarefa> RetornarTodasNaoConcluidas(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tarefa> RetornarTodasPorPeriodo(string usuario, DateTime data, bool concluido)
        {
            throw new NotImplementedException();
        }
    }
}
