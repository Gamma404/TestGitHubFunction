using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models.ViewModels
{
    public class RecordOfAccountModel
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}