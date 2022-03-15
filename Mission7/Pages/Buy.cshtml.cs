﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7.Infrastructure;
using Mission7.Models;

namespace Mission7.Pages
{
    public class BuyModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public Cart cart { get; set; }

        public string ReturnUrl { get; set; }

        public BuyModel (IBookstoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Books b = repo.Books.FirstOrDefault(b => b.BookID == bookId);

            cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostDelete(int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(b => b.Books.BookID == bookId).Books);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}