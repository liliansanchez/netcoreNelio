using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context) 
        {
            _context = context;
        }

        //operacao sincrona = roda o acesso ao banco de dados e a aplicacao vai ficar bloqueada esperando esta operacao 
        //terminar
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Department obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
