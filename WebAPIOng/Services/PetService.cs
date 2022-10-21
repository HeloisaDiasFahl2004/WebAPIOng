using MongoDB.Driver;
using System.Collections.Generic;
using WebAPIOng.Models;
using WebAPIOng.Utils;

namespace WebAPIOng.Services
{
    public class PetService
    {
        private readonly IMongoCollection<Pet> _pet;
        public PetService(IDatabaseSettings settings)
        {
            var con = new MongoClient(settings.ConnectionString);
            var database = con.GetDatabase(settings.DatabaseName);
            _pet = database.GetCollection<Pet>(settings.PetCollectionName);
        }
        public Pet Create(Pet pet)
        {
            _pet.InsertOne(pet);
            return pet;
        }
        public List<Pet> GetAll() => _pet.Find<Pet>(pet => true).ToList();
        public Pet GetByName(string nome) => _pet.Find<Pet>(pet => pet.Nome == nome).FirstOrDefault();
     
    }
}
