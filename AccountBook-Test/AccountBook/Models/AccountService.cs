using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountBook.Controllers;
using AccountBook.Models.ViewModels;
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

        public IEnumerable<RecordOfAccountModel> Lookup()
        {
            var source = _accountBookRep.LookupAll();
            var result = source.Select(item => new RecordOfAccountModel()
            {
                Id = 0,
                Type = item.Categoryyy,
                Date = item.Dateee,
                Money = item.Amounttt,
                Description = item.Remarkkk
            });
            return result;
        }
    }
}