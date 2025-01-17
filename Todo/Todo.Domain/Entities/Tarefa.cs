﻿using System;

namespace Todo.Domain.Entities
{
    public class Tarefa : BaseEntity
    {
        public Tarefa(string titulo, DateTime data, string usuario)
        {
            Titulo = titulo;
            Concluido = false;
            Data = data;
            Usuario = usuario;
        }

        public string Titulo { get; private set; }
        public bool Concluido { get; private set; }
        public DateTime Data { get; private set; }
        public string Usuario { get; private set; }

        public void MarcarComoConcluido()
        {
            Concluido = true;
        }

        public void MarcarComoNaoConcluido()
        {
            Concluido = false;
        }

        public void AtualizarTitulo(string titulo)
        {
            Titulo = titulo;
        }
    }
}