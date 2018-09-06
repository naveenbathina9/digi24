﻿using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface ISubjectService
    {
        ServiceResponse<bool> CreateSubject(string title, string standardId);
        ServiceResponse<List<Subject>> GetAllSubjects();
    }
}
