﻿using System.ComponentModel.DataAnnotations;

namespace Filmes_Api.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
