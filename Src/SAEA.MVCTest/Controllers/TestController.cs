﻿using SAEA.MVC;

namespace SAEA.MVCTest.Controllers
{
    /// <summary>
    /// test
    /// </summary>
    public class TestController: Controller
    {
        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public ActionResult Test()
        {
            return Content("this is a test!");
        }
    }
}
