using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryWebApi.DbModels
{
    public class Game
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
