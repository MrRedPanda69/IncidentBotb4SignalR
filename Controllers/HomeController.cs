// <copyright file="HomeController.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// </copyright>

namespace Sample.IncidentBot.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The home controller class.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Get the default content of home page.
        /// </summary>
        /// <returns>Default content.</returns>
        ///
        [HttpGet("/")]
        public IActionResult Get()
        {
            return this.View("home");
        }
    }
}