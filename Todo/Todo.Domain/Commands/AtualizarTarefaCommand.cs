﻿using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class AtualizarTarefaCommand : Notifiable, ICommand
    {
        public AtualizarTarefaCommand() { }

        public AtualizarTarefaCommand(Guid id, string titulo, string usuario)
        {
            Id = id;
            Titulo = titulo;
            Usuario = usuario;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Usuario { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Titulo, 3, "Titulo", "Por favor, descreva melhor esta tarefa!")
                    .HasMinLen(Usuario, 6, "Usuario", "Usuário inválido!")
            );
        }
    }
}
