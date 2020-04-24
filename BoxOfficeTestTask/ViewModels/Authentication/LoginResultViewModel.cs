﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxOfficeTestTask.ViewModels.Authentication
{
    public class LoginResultViewModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
