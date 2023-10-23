using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DockerTest2.Models;

namespace DockerTest2.Data
{
    public class DockerTest2Context : DbContext
    {
        public DockerTest2Context (DbContextOptions<DockerTest2Context> options)
            : base(options)
        {
        }

        public DbSet<DockerTest2.Models.Users> users { get; set; } = default!;
    }
}
