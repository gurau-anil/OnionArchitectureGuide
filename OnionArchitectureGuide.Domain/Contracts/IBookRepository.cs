﻿using OnionArchitectureGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureGuide.Domain.Contracts
{
    public interface IBookRepository
    {
        Task<Book> GetAllAsync();
    }
}
