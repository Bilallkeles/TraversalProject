using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial    
    {
        [Key]
        public int TestimonialId { get; set; }

        public string Description { get; set; }

        public string Customer { get; set; }

        public string CustomerImage { get; set; }

        public bool Statu { get; set; }
    }
}
