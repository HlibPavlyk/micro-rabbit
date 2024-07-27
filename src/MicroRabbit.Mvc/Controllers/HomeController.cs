using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MicroRabbit.Mvc.Models;
using MicroRabbit.Mvc.Models.Dtos;
using MicroRabbit.Mvc.Services;

namespace MicroRabbit.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ITransferService _transferService;

    public HomeController(ITransferService transferService)
    {
        _transferService = transferService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    [HttpPost]
    public async Task<IActionResult> Transfer(TransferViewModel transferViewModel)
    {
        if (ModelState.IsValid)
        {
            var transferDto = new TransferDto
            {
                FromAccount = transferViewModel.FromAccount,
                ToAccount = transferViewModel.ToAccount,
                TransferAmount = transferViewModel.TransferAmount
            };
            await _transferService.Transfer(transferDto);
            return RedirectToAction("Index");
        }
        return View("Index");
    }
}