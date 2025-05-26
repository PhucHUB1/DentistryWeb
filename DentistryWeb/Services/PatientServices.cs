using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DentistryWeb.Models;

namespace DentistryWeb.Services
{
    public class PatientServices
    {
        private List<Patient> patients = new();

        public List<Patient> GetAll() => patients.OrderByDescending(p => p.CreatedAt).ToList();

        public Patient? GetById(Guid id) => patients.FirstOrDefault(p => p.Id == id);

        public void Add(Patient patient)
        {
            patient.Id = Guid.NewGuid();
            patient.CreatedAt = DateTime.Now;
            patients.Add(patient);
        }

        public void Update(Patient updatedPatient)
        {
            var existing = GetById(updatedPatient.Id);
            if (existing == null) return;

            existing.Name = updatedPatient.Name;
            existing.Gender = updatedPatient.Gender;
            existing.DateOfBirth = updatedPatient.DateOfBirth;
            existing.Phone = updatedPatient.Phone;
            existing.Career = updatedPatient.Career;
            existing.Address = updatedPatient.Address;
        }

        public void Delete(Guid id)
        {
            var p = GetById(id);
            if (p != null)
                patients.Remove(p);
        }
    }
}
