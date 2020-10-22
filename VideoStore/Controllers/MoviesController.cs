using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies/Random
		public ActionResult Random()
		{
			Movie movie = new Movie() { Name = "Shrek!" };
			var customers = new List<Customer>
			{
				new Customer {Name = "Customer 1"},
				new Customer {Name = "Customer 2"}
			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
		}

	}
}