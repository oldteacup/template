// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using VisionSystem.Core.IServices;

namespace VisionSystem.Core.Services
{
    internal class HomeService : IHomeService
    {
        private readonly ILogService _logService;

        public HomeService(ILogService logService)
        {
            _logService = logService;
        }

        public string SayHello()
        {
            _logService.Information("Say Hello Method Invoke !");
            return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss:fff} \t Hello Service Core !";
        }
    }
}
