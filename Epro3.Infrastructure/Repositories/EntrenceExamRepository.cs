﻿using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories
{
    public class EntrenceExamRepository : GenericRepository<EntrenceExam>, IEntrenceExamRepository
    {
        public EntrenceExamRepository(ApplicationDatabaseContext context) : base(context)
        {
        }
    }
}