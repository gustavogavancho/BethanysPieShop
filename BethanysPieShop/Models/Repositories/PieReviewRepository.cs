﻿using BethanysPieShop.Data;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models.Repositories
{
    public class PieReviewRepository : IPieReviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieReviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddPieReview(PieReview pieReview)
        {
            _appDbContext.PieReviews.Add(pieReview);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<PieReview> GetReviewsForPie(int pieId)
        {
            return _appDbContext.PieReviews.Where(p => p.Pie.PieId == pieId);
        }
    }
}
