using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PCyP.Biz
{
    public class Category : EntityBase
    {
        public String name { get; set; }
        public Category()
        {
            this.CreatedOn = DateTime.Now;
            this.ChangedOn = DateTime.Now;
        }
    }
}
