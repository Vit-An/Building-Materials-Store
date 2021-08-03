﻿using DataAccess.Repository.IRepisitory;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DataAccess.Repository
{
    public class InquiryDetailRepository : Repository<InquiryDetail>, IInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryDetailRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(InquiryDetail obj)
        {
            _db.InquiryDetail.Update(obj);
        }
    }
}
