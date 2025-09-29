using Exo.WebApi.Models;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {
        public List<Projeto> Listar()
        {
            // Dados de teste - remove depois que conectar ao banco
            return new List<Projeto>
            {
                new Projeto { Id = 1, NomeDoProjeto = "API Sistema", Area = "TI", Status = true },
                new Projeto { Id = 2, NomeDoProjeto = "Site Corporativo", Area = "Marketing", Status = false },
                new Projeto { Id = 3, NomeDoProjeto = "App Mobile", Area = "TI", Status = true }
            };
        }
    }
}