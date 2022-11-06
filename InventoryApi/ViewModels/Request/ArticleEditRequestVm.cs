using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModels.Request
{
    public class ArticleEditRequestVm
    {
        [Range(0, int.MaxValue, ErrorMessage = "Cannot be negative number")]
        public int Id { get; set; }

        [Required]
        public string Ref { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int ArticleTypeId { get; set; }
    }
}
