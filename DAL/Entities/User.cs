using System.ComponentModel.DataAnnotations;

namespace ASPDotNETCoreWebApiBoilerPlate.DAL.Entities
{
    public class User
    {
        [Key]
        public long id { get; set; }

        public string name { get; set; }

        public int age { get; set; }
        public bool is_adult { get; set; } = false;
        public bool is_active { get; set; } = true;

    }
}
