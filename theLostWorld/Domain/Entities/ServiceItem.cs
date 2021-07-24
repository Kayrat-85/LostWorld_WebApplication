using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace theLostWorld.Domain.Entities
{
    public class ServiceItem: EntityBase
    {
        [Required(ErrorMessage = "Заполните название новости")]
        [Display(Name = "Название новости")]
        public override string Title { get; set; }
        [Display(Name = "Краткое описание статьи")]
        public override string Subtitle { get; set; }
        [Display(Name = "Полное описание статьи")]
        public override string Text { get; set; }

    }
}
