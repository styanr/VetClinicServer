using Bogus;
using VetClinicServer.Models;

namespace VetClinicServer.Utils
{
    public class DatabaseSeeder
    {
        public IReadOnlyCollection<Client> Clients { get; set; }
        public IReadOnlyCollection<Patient> Patients { get; set; }
        public IReadOnlyCollection<Doctor> Doctors { get; set; }
        public IReadOnlyCollection<Appointment> Appointments { get; set; }

        public DatabaseSeeder(int clientAmt, int patientAmt, int doctorAmt, int appointmentAmt)
        {
            Clients = GenerateClients(clientAmt);
            Patients = GeneratePatients(patientAmt, clientAmt);
            Doctors = GenerateDoctors(doctorAmt);
            Appointments = GenerateAppointments(appointmentAmt, doctorAmt, patientAmt);
        }

        private static IReadOnlyCollection<Client> GenerateClients(int amt)
        {
            int id = 1;
            var clientFaker = new Faker<Client>();

            clientFaker.RuleFor(c => c.ClientId, f => id++);
            clientFaker.RuleFor(c => c.FirstName, f => f.Name.FirstName());
            clientFaker.RuleFor(c => c.LastName, f => f.Name.LastName());
            clientFaker.RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumberFormat());
            clientFaker.RuleFor(c => c.Email, f => f.Internet.Email());
            clientFaker.RuleFor(c => c.PostalCode, f => f.Address.ZipCode());
            clientFaker.RuleFor(c => c.Address, f => f.Address.FullAddress());

            return clientFaker.Generate(amt);
        }

        private static IReadOnlyCollection<Patient> GeneratePatients(int amt, int clientAmt)
        {
            int id = 1;
            var patientFaker = new Faker<Patient>();

            patientFaker.RuleFor(p => p.PatientId, f => id++);
            patientFaker.RuleFor(p => p.Species, f => f.PickRandom(
                "Dog", "Cat", "Bird", "Rabbit", "Hamster"));
            patientFaker.RuleFor(p => p.Breed, f => f.PickRandom(
            "Labrador", "German Shepherd", "Beagle", "Poodle", "Bulldog", "Persian", 
            "Siamese", "Maine Coon", "Bengal", "Sphynx", "Parrot", "Canary", "Finch", "Cockatiel", 
            "Budgie", "Lionhead", "Angora", "Dutch", "Lop", "Rex", "Syrian", "Dwarf", "Chinese", 
            "Roborovski", "Winter White"
            ));

            patientFaker.RuleFor(p => p.Name, f => f.Name.FirstName());
            patientFaker.RuleFor(p => p.DateOfBirth, f => f.Date.Past(10,
                refDate: new DateTime(2023, 11, 13)));
            patientFaker.RuleFor(p => p.ClientId, f => f.Random.Number(1, clientAmt));
            
            return patientFaker.Generate(amt);
        }

        private static IReadOnlyCollection<Doctor> GenerateDoctors(int amt)
        {
            int id = 1;
            var doctorFaker = new Faker<Doctor>();

            doctorFaker.RuleFor(d => d.DoctorId, f => id++);
            doctorFaker.RuleFor(d => d.FirstName, f => f.Name.FirstName());
            doctorFaker.RuleFor(d => d.LastName, f => f.Name.LastName());
            doctorFaker.RuleFor(d => d.PostalCode, f => f.Address.ZipCode());
            doctorFaker.RuleFor(d => d.Address, f => f.Address.FullAddress());
            doctorFaker.RuleFor(d => d.Specialization, f => f.PickRandom<DoctorSpecialization>());

            return doctorFaker.Generate(amt);
        }

        private static IReadOnlyCollection<Appointment> GenerateAppointments(int amt, int doctorAmt, int patientAmt)
        {
            int id = 1;
            var appointmentFaker = new Faker<Appointment>();

            appointmentFaker.RuleFor(a => a.AppointmentId, f => id++);
            appointmentFaker.RuleFor(a => a.Date, f => f.Date.Future(1, refDate: new DateTime(2023, 11, 13)));
            appointmentFaker.RuleFor(a => a.DoctorId, f => f.Random.Number(1, doctorAmt));
            appointmentFaker.RuleFor(a => a.PatientId, f => f.Random.Number(1, patientAmt));
            appointmentFaker.RuleFor(a => a.Type, f => f.PickRandom<AppointmentType>());

            return appointmentFaker.Generate(amt);
        }

    }
}
