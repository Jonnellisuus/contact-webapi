﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactWebapiContext _context;

        public ContactRepository(ContactWebapiContext context)
        {
            _context = context;
        }

        public Contact Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public void Delete(long id)
        {
            var deleteContact = Read(id);
            _context.Remove(deleteContact);
            _context.SaveChanges();
            return;
        }

        public List<Contact> Read()
        {
            return _context.Contact.AsNoTracking().ToList();
        }

        public Contact Read(long id)
        {
            return _context.Contact.FirstOrDefault(c => c.Id == id);
        }

        public Contact Update(Contact contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
            return contact;
        }
    }
}
