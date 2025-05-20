using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistryWeb.Models
{
    public class Patient
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Nghề nghiệp không được để trống")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
