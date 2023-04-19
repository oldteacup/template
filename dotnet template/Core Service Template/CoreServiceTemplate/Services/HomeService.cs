using CoreServiceTemplate.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServiceTemplate.Services
{
    internal class HomeService : IHomeService
    {
        private ILogService _logService;

        public HomeService(ILogService logService)
        {
            _logService = logService;
        }

        public string SayHello()
        {
            _logService.Information("Say Hello Method Invoke !");
            return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss:fff} \t Hello Core Service !";
        }
    }
}
