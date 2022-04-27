using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASPNET Core", "Minha Descricao de Projeto", 1, 1, 10000),
                new Project("Meu Projeto ASPNET Core", "Minha Descricao de Projeto", 1, 1, 15000),
                new Project("Meu Projeto ASPNET Core", "Minha Descricao de Projeto", 1, 1, 20000)
            };

            Users = new List<User>
            {
                new User("Daniel Vieira","Daniel@gmail.com", new DateTime(1997, 1, 1)),
                new User("Luis Dev","Luisdev@luisdev.com", new DateTime(1992, 1, 1)),
                new User("Robert C Martin","robertcmartin@gmail.com", new DateTime(1952, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill("C#"),
                new Skill("SQL")
            };

        }

        public List<Project> Projects { get; private set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjectComment> ProjectComments { get; set; }
    }
}
