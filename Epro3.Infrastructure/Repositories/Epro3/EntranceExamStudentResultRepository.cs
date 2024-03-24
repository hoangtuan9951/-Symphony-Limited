﻿using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories.Epro3
{
    public class EntranceExamStudentResultRepository : GenericRepository<EntranceExamStudentResult>, IEntranceExamStudentResultRepository
    {
        public EntranceExamStudentResultRepository(ApplicationDatabaseContext context) : base(context)
        {
        }
    }
}
