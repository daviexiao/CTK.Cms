﻿using Microsoft.AspNetCore.Mvc;
using Sample01.Models;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.FileProviders.Composite;
using Microsoft.Extensions.Options;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;

        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        // GET
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content
            //        { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}

            return View(new ContentViewModel {Contents = new List<Content> {contents}});
        }
    }
}