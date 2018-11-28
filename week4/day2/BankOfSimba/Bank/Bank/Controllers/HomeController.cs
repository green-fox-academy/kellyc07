using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        static List<BankAccount> bankAccountlist = new List<BankAccount>();
        
        [HttpGet("show")]
        public IActionResult Index()
        {
            BankAccount account = new BankAccount("Simba", 2000, "lion");
            return View(account);
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            bankAccountlist.Add(new BankAccount("tiger", 888, "cat"));
            bankAccountlist.Add(new BankAccount("kelly", 999, "dog"));
            bankAccountlist.Add(new BankAccount("chay", 777, "cow"));
            bankAccountlist.Add(BankAccount Name);
            return View(bankAccountlist);
        }


    }
}

