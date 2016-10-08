using System.ComponentModel.DataAnnotations;

namespace Dream.Data
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string Name { get; set; }
    }
}
