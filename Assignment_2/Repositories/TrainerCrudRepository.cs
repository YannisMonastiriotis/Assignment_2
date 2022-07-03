using Assignment_2.Models;
using Assignment_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Repositories
{
    public class TrainerCrudRepository: IDisposable
    {
        private readonly ApplicationDbContext _context;

        public TrainerCrudRepository()
        {
            _context = new ApplicationDbContext();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public TrainerViewModel MatchTrainerViewModel(int? id)
        {
            var trainerViewModel = GetById(id);
            var viewModel = new TrainerViewModel()
            {
                Details = trainerViewModel.Details,
                BirthDate = trainerViewModel.BirthDate,
                City = trainerViewModel.City,
                Country = trainerViewModel.Country,
                PostalCode = trainerViewModel.PostalCode,
                PhoneNum = trainerViewModel.PhoneNum,
                EmailAddress = trainerViewModel.EmailAddress,
                FirstName = trainerViewModel.FirstName,
                MiddleName = trainerViewModel.MiddleName,
                LastName = trainerViewModel.LastName,
                Gender = trainerViewModel.Gender,
                StreetName = trainerViewModel.StreetName,
                Salary = trainerViewModel.Salary,
                StreetNo = trainerViewModel.StreetNo
            };
            return viewModel;

        }
        public void Create (Trainer trainer)
        {
            if (trainer == null)
                throw new HttpException(404, "Error at the beginning of Creation");
               _context.Trainers.Add(trainer);
            _context.Trainers.Add(trainer);
            Save();
        }
        public void Create(TrainerViewModel trainerViewModel)
        {
            if (trainerViewModel == null)
                throw new HttpException(404, "Error at the beginning of Creation");

            var trainer = new Trainer()
            {

                Details = trainerViewModel.Details,
                BirthDate = trainerViewModel.BirthDate,
                City = trainerViewModel.City,
                Country = trainerViewModel.Country,
                PostalCode = trainerViewModel.PostalCode,
                PhoneNum = trainerViewModel.PhoneNum,
                EmailAddress = trainerViewModel.EmailAddress,
                FirstName = trainerViewModel.FirstName,
                MiddleName = trainerViewModel.MiddleName,
                LastName = trainerViewModel.LastName,
                Gender = trainerViewModel.Gender,
                StreetName = trainerViewModel.StreetName,
                Salary = trainerViewModel.Salary,
                StreetNo = trainerViewModel.StreetNo
            };

            _context.Trainers.Add(trainer);
                Save();
        }
        public IEnumerable<Trainer> GetAll()
        {
            var trainers = _context
                .Trainers;

            return trainers;
        }

        public Trainer GetById(int? id)
        {

            if (id == 0)
                throw new HttpException(404, "Error at the beginning of Geting");
            var trainer = GetAll()
                .SingleOrDefault(t => t.Id == id);

            return trainer;
        }
        public void Update(Trainer trainer)
        {
            if (trainer == null)
                throw new HttpException(404, "Error at the beginning of Creation");

            _context.Entry(trainer).State = EntityState.Modified;
            Save();

        }

        public void Delete(int? id)
        {
            if (id == 0)
                throw new HttpException(404, "Error at the beginning of Deletion");

            var trainer = GetById(id);

            _context.Trainers.Remove(trainer);
            Save();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}