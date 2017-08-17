using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models
{
    public class AccountService
    {
        private readonly SkillTreeHomeworkEntities _db;

        //private readonly Database1Entities _db;
        public AccountService()
        {
            _db = new SkillTreeHomeworkEntities();
            //_db = new Database1Entities();
        }

        public IEnumerable<AccountBook> GetSource()
        {
            var source = from s in _db.AccountBook select s;

            return source;
        }
    }
}