using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace theLostWorld.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";
        [Display(Name = "Cодержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";

    }
}
