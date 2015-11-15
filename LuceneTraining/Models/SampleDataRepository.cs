using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuceneTraining.Models
{
    public static class SampleDataRepository
    {
        public static SampleData Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.Id.Equals(id));
        }
        public static List<SampleData> GetAll()
        {
            return new List<SampleData> {
                new SampleData {Id = 1, Name = "We Are The In Crowd", Description = "American pop punk band from Poughkeepsie"},
                new SampleData {Id = 2, Name = "Patent Pending", Description = "American pop punk band consisting of vocalist Joe Ragosta, drummer Anthony Mingoia, guitarist Marc Kantor, guitarist/vocalist Rob Felicetti, and bassist Corey DeVincenzo. The band is from Mount Sinai, New York."},
                new SampleData {Id = 3, Name = "Super Happy Fun Club", Description = "The Super Happy Fun Club (aka Super Happy Fun Club, or SHFC) is an American piano rock band from Chicago, Illinois."},
                new SampleData {Id = 4, Name = "Blink 182", Description = "Blink-182 is an American rock band formed in Poway, a suburb of San Diego, California, in 1992"},
                new SampleData {Id = 5, Name = "New Found Glory", Description = "American rock band from Coral Springs, Florida, formed in 1997"},
            };
        }
    }
}