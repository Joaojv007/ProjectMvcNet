﻿using Microsoft.AspNetCore.Mvc;
using ProjectMvcNet.Models;
using ProjectMvcNet.Models.ViewModels;
using ProjectMvcNet.Services;

namespace ProjectMvcNet.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmenteService _departmenteService;

        public SellersController(SellerService sellerService, DepartmenteService departmenteService)
        {
            _sellerService = sellerService;
            _departmenteService = departmenteService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmenteService.FindAll(); 
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
