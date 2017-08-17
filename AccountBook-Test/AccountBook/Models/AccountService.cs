using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountBook.Controllers;
using AccountBook.Repositories;

namespace AccountBook.Models
{
    public class AccountService
    {
        private readonly IRepository<AccountBook> _accountBookRep;
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountBookRep = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountBook> Lookup()
        {
            var source = _accountBookRep.LookupAll();
            return source;
        }
    }
}