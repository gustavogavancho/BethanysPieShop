using BethanysPieShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<Pie> IPieRepository.AllPies
        {
            get
            {
                return _appDbContext.Pies
                    .Include(x=> x.Category);
            }
        }

        IEnumerable<Pie> IPieRepository.PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies
                    .Include(x => x.Category)
                    .Where(x=> x.IsPieOfTheWeek);
            }
        }

        Pie IPieRepository.GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}