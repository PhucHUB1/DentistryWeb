using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistryWeb.Models;

namespace DentistryWeb.Services
{
    public class PatientService
    {
        private List<Patient> _patients;

        public PatientService()
        {
            // Tạo dữ liệu mẫu
            _patients = new List<Patient>
            {
                new Patient
                {
                    Id = "c6e6838a-621e-4cee-8448-35acb6c1eb7e",
                    Name = "Bệnh nhân D",
                    Gender = "Nam",
                    BirthDate = new DateTime(2005, 5, 9),
                    Occupation = "Học sinh",
                    PhoneNumber = "0100000202",
                    Address = "Hai Bà Trưng, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 13, 55, 52)
                },
                new Patient
                {
                    Id = "c6ec7d5f-4b3d-4e47-869f-7d6fc44f58b5",
                    Name = "Bệnh nhân B",
                    Gender = "Nam",
                    BirthDate = new DateTime(2024, 6, 28),
                    Occupation = "Bác sĩ thú y",
                    PhoneNumber = "0100000034",
                    Address = "Đống Đa",
                    CreatedDate = new DateTime(2024, 6, 28, 2, 22, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân M",
                    Gender = "Nữ",
                    BirthDate = new DateTime(1, 1, 1),
                    Occupation = "Học sinh",
                    PhoneNumber = "0100005803",
                    Address = "Thanh Xuân, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 56, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân E",
                    Gender = "Nữ",
                    BirthDate = new DateTime(2005, 5, 9),
                    Occupation = "Sinh viên",
                    PhoneNumber = "0100000204",
                    Address = "Thanh Xuân, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 55, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân C",
                    Gender = "Nữ",
                    BirthDate = new DateTime(2003, 10, 7),
                    Occupation = "Ca sĩ",
                    PhoneNumber = "0100000005",
                    Address = "Hà Đông, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 54, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân B",
                    Gender = "Nam",
                    BirthDate = new DateTime(1998, 10, 15),
                    Occupation = "Sinh viên",
                    PhoneNumber = "0100000002",
                    Address = "Đống Đa, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 53, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân F",
                    Gender = "Nữ",
                    BirthDate = new DateTime(2004, 8, 18),
                    Occupation = "Bác sĩ thú y",
                    PhoneNumber = "0100000001",
                    Address = "Hai Bà Trưng, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 52, 0)
                },
                new Patient
                {
                    Name = "Bệnh nhân A",
                    Gender = "Nam",
                    BirthDate = new DateTime(2024, 6, 28),
                    Occupation = "Doanh nhân",
                    PhoneNumber = "0000000000",
                    Address = "Cau Giấy, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 44, 0)
                }
            };
        }

        // Lấy tất cả bệnh nhân
        public List<Patient> GetAllPatients()
        {
            return _patients;
        }

        // Tìm bệnh nhân theo ID
        public Patient GetPatientById(string id)
        {
            return _patients.FirstOrDefault(p => p.Id == id);
        }

        // Thêm bệnh nhân mới
        public void AddPatient(Patient patient)
        {
            if (string.IsNullOrEmpty(patient.Id))
            {
                patient.Id = Guid.NewGuid().ToString();
            }
            patient.CreatedDate = DateTime.Now;
            _patients.Add(patient);
        }

        // Cập nhật thông tin bệnh nhân
        public void UpdatePatient(Patient patient)
        {
            var existingPatient = _patients.FirstOrDefault(p => p.Id == patient.Id);
            if (existingPatient != null)
            {
                var index = _patients.IndexOf(existingPatient);
                _patients[index] = patient;
            }
        }

        // Xóa bệnh nhân
        public void DeletePatient(string id)
        {
            var patient = _patients.FirstOrDefault(p => p.Id == id);
            if (patient != null)
            {
                _patients.Remove(patient);
            }
        }
    }
}
