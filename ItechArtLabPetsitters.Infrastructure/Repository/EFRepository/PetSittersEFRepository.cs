﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Infrastructure.Context;
using ItechArtLabPetsitters.Repository.Interface;
using ItechArtLabPetsitters.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItechArtLabPetsitters.Infrastructure.Repository.EFRepository
{
    public class PetSittersEFRepository:IPetsittersRepository
    {
        private readonly PetsittersContext _dbContext;
        public PetSittersEFRepository(PetsittersContext context) => this._dbContext = context;

        public async Task AddPetsitterAsync(string name, string phoneNumber)
        {
            _dbContext.Petsitters.Add(new Petsitter(name, phoneNumber));
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePetsitterAsync(long ID)
        {
            Petsitter deletedPetsitter = await _dbContext.Petsitters.FirstAsync(p => p._ID == ID); 
            _dbContext.Petsitters.Remove(deletedPetsitter);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Petsitter>> GetAllPetsittersAsync()
        {
            return await _dbContext.Petsitters.ToListAsync();
        }
    }
}