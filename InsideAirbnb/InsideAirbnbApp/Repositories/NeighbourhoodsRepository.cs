﻿using System;
using System.Linq;
using InsideAirbnbApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InsideAirbnbApp.Repositories
{
    public class NeighbourhoodsRepository : IRepository<Neighbourhoods>
    {
        private readonly AirbnbContext _context;
        public NeighbourhoodsRepository(AirbnbContext context)
        {
            _context = context;
        }

        public Neighbourhoods Get(int id)
        {
            throw new NotImplementedException();
        }

        public Neighbourhoods Get(string id)
        {
            return _context.Neighbourhoods.First(n => n.Neighbourhood == id);
        }

        public IQueryable<Neighbourhoods> All()
        {
            return _context.Neighbourhoods.AsNoTracking();
        }
    }
}
