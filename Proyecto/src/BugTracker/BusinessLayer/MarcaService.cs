using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Entities;
using BugTracker.DataAccessLayer;

namespace BugTracker.BusinessLayer
{
    public class MarcaService
    {
        private MarcaDao oMarcaDao;
        public MarcaService()
        {
            oMarcaDao = new MarcaDao();
        }
        public IList<Marca> ObtenerTodos()
        {
            return oMarcaDao.GetAll();
        }

    }
}
