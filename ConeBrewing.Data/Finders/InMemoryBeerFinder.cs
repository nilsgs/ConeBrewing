using ConeBrewing.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConeBrewing.Data.Finders
{
    public class InMemoryBeerFinder : IBeerFinder
    {
        private List<Beer> _beers = new List<Beer>();

        public InMemoryBeerFinder()
        {
            CreateBeers();
        }
        
        public Beer Get(int id)
        {
            return _beers.Find(b => b.Id == id);
        }

        public IEnumerable<Beer> GetAll()
        {
            return _beers;
        }

        private void CreateBeers()
        {
            var gz = new Beer
            {
                Id = 1,
                Name = "Ground Zero",
                Description = "First beer ever"
            };

            _beers.Add(gz);

            var rfh = new Beer
            {
                Id = 2,
                Name = "Recipe For Hate",
                Description = "The second beer"
            };

            _beers.Add(rfh);
        }
    }
}
