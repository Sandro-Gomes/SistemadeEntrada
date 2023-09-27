﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeEntrada.Entitites.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string? message) : base(message)
        {

        }
    }
}
