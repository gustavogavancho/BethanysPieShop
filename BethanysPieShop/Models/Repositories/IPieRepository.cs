using System.Collections.Generic;

namespace BethanysPieShop.Models.Repositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
        void CreatePie(Pie pie);

        void UpdatePie(Pie pie);
    }
}