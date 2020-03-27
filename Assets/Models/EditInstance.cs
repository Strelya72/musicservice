using Microsoft.AspNetCore.Mvc.ModelBinding;
using MusicService.Assets.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicService.Assets.Models
{
    public class EditInstance
    {
        public int Id { get; set; }

        [Display(Name = "Введите название песни")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [MinLength(5)]
        public string Title { get; set; }

        [Display(Name = "Укажите стоимость")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [MinLength(1)]
        public string Price { get; set; }
    }
}
