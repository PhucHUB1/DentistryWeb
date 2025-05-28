using DentistryWeb.Models;

namespace DentistryWeb.Services
{
    public class PatientServices
    {
        private readonly List<Patient> patients = new();

        public List<Patient> GetAll() => patients.OrderByDescending(p => p.CreatedAt).ToList();

        public Patient? GetById(Guid id) => patients.FirstOrDefault(p => p.Id == id);

        public void Add(Patient p)
        {
            p.Id = Guid.NewGuid();
            p.CreatedAt = DateTime.Now;
            patients.Add(p);
        }

        public void Update(Patient p)
        {
            var existing = GetById(p.Id);
            if (existing is null) return;

            existing.Name = p.Name;
            existing.Gender = p.Gender;
            existing.DateOfBirth = p.DateOfBirth;
            existing.Career = p.Career;
            existing.Phone = p.Phone;
            existing.Address = p.Address;
        }

        public void Delete(Guid id)
        {
            var p = GetById(id);
            if (p is not null)
                patients.Remove(p);
        }
    }
}
