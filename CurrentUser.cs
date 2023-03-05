using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Performance_Assessment
{
    public class CurrentUser
    {
        public static CurrentUser instance;
        public int Id { get; set; }
        public string Name { get; set; }

        private CurrentUser()
        {

        }

        public static CurrentUser GetInstance()
        {
            if(instance == null)
            {
                instance = new CurrentUser();
            }

            return instance;
        }

    
    }
}
