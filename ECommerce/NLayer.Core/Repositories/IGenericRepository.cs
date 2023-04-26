using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public class IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
    }
}
