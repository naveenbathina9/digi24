﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Contracts
{
    using Entities;
    using Infrastructure;
    public interface IHomeworkRepository: IRepository<HomeWorkEntity>
    {

        HomeWorkEntity GetByids(string SubjId, string standId, DateTime date);
    }
}
