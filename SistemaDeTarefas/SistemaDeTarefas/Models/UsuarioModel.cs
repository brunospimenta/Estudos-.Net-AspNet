﻿using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        [Key]

        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Email { get; set;}


    }
}
