using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{

    public class EmailService
    {
        private SeedingService _seeding;

        public EmailService(SeedingService seeding)
        {
            _seeding = seeding;
        }

        public void Execute()
        {
            var x = _seeding.RetValue();
        }
       
    }
}
