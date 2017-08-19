﻿using Nancy;

namespace Trinket.Api.Controller
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            this.Get("", args => this.Home());
        }

        public object Home()
        {
            #region Text Home

            var text = @"


            .----------------.  .----------------.  .----------------.  .-----------------. .----------------.  .----------------.  .----------------. 
           | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
           | |  _________   | || |  _______     | || |     _____    | || | ____  _____  | || |  ___  ____   | || |  _________   | || |  _________   | |
           | | |  _   _  |  | || | |_   __ \    | || |    |_   _|   | || ||_   \|_   _| | || | |_  ||_  _|  | || | |_   ___  |  | || | |  _   _  |  | |
           | | |_/ | | \_|  | || |   | |__) |   | || |      | |     | || |  |   \ | |   | || |   | |_/ /    | || |   | |_  \_|  | || | |_/ | | \_|  | |
           | |     | |      | || |   |  __ /    | || |      | |     | || |  | |\ \| |   | || |   |  __'.    | || |   |  _|  _   | || |     | |      | |
           | |    _| |_     | || |  _| |  \ \_  | || |     _| |_    | || | _| |_\   |_  | || |  _| |  \ \_  | || |  _| |___/ |  | || |    _| |_     | |
           | |   |_____|    | || | |____| |___| | || |    |_____|   | || ||_____|\____| | || | |____||____| | || | |_________|  | || |   |_____|    | |
           | |              | || |              | || |              | || |              | || |              | || |              | || |              | |
           | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
            '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' ";
            #endregion

            return Response.AsText(text);
        }
    }
}
