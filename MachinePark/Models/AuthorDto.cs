﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Models
{
    public class AuthorDto
    {

        public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        //Nav properties
        public ICollection<AuthorWorkDto> Works { get; set; } // Circular WARNING Works <=> Authors
                                                              // Todo Also change the Parameter Name to something presentable such as Works

    }
    public class AuthorWorkDto // A Class to Prevent Circular References.
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int TypeId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Level { get; set; }

        public DateTime PublicationDate { get; set; }

        //public ICollection<Author> Authors { get; set; }
        //public Genre Genre { get; set; }

        //public Entities.Type Type { get; set; }
    }
}
