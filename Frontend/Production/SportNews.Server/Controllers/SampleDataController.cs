using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportNews.Shared;
using SportNews.Shared.Models;

namespace SportNews.Server.Controllers
{
	[Route("api/[controller]")]
	public class SampleDataController : Controller
	{
		private static readonly string[] Summaries =
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		[HttpGet("[action]")]
		public IEnumerable<WeatherForecast> WeatherForecasts()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			});
		}

		[HttpGet("[action]")]
		public IEnumerable<Article> Football()
		{
			var articles = new List<Article>
			{
				new Article{Title = "Football Title 1"},
				new Article{Title = "Football Title 2"},
				new Article{Title = "Football Title 3"},
				new Article{Title = "Football Title 4"},
				new Article{Title = "Football Title 5"},
				new Article{Title = "Football Title 6"},
			};

			return articles;
		}

		[HttpGet("[action]")]
		public IEnumerable<Article> Basketball()
		{
			var articles = new List<Article>
			{
				new Article{Title = "Basketball Title 1"},
				new Article{Title = "Basketball Title 2"},
				new Article{Title = "Basketball Title 3"},
				new Article{Title = "Basketball Title 4"},
				new Article{Title = "Basketball Title 5"},
				new Article{Title = "Basketball Title 6"},
			};

			return articles;
		}

		[HttpGet("[action]")]
		public IEnumerable<Article> Sport()
		{
			var articles = new List<Article>
			{
				new Article{Title = "Basketball Title 1"},
				new Article{Title = "Football Title 2"},
				new Article{Title = "Basketball Title 3"},
				new Article{Title = "Football Title 4"},
				new Article{Title = "Basketball Title 5"},
				new Article{Title = "Football Title 6"},
			};

			return articles;
		}
	}
}