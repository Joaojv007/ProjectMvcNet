using ProjectMvcNet.Data;
using System.Linq;
using ProjectMvcNet.Models;
using System.Collections.Generic;
using System;

namespace ProjectMvcNet.Services
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {

        }
    }
}
