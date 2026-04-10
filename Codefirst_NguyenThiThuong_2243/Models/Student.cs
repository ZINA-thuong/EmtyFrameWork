using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Codefirst_NguyenThiThuong_2243.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Ten ko dc de trong")]
        [StringLength(100)]
        public string FullName { get; set; }
        public int Age { set; get; }


    }
}
