using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Zuvytes.ViewModels
{
    public class ModelisEditViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Pavadinimas")]
        [MaxLength(20)]
        [Required]
        public string pavadinimas { get; set; }
        [DisplayName("Markė")]
        [Required]
        public int fk_marke { get; set; }

        //Markiu sąrašas pasirinkimui
        public IList<SelectListItem> MarkesList { get; set; }
    }
}