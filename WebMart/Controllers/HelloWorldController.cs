﻿using System.Web;
using System.Web.Mvc;

namespace WebMart.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name,int id=1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", Id is: " + id);
        }
    }
}