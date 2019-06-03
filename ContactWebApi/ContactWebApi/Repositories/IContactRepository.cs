﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repositories
{
    public interface IContactRepository
    {
        Contact Create(Contact contact);
        List<Contact> Read();
        Contact Read(long id);
        Contact Update(Contact contact);
        void Delete(long id);
    }
}
