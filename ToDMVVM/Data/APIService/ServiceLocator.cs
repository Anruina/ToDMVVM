using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDMVVM.Data.APIService
{
    public static class ServiceLocator
    {
        public static MemeService memeService = new MemeService();
    }
}
