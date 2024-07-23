﻿using Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOperationResultService
    {
        OperationResult CreateSuccessResult(string mesage);
        OperationResult CreateFailResult(string mesage);
    }
}
