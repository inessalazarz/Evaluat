namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Eval
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Sex { get; set; }



    }
}