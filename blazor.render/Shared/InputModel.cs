using System.ComponentModel.DataAnnotations;

namespace blazor.render.Shared
{
    public class InputModel
    {
        [Required]
        public int Temperature { get; set; }
    }
}
