using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestMakerFree.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        //[HttpGet("[action]")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    });
        //}


        [HttpGet("[action]")]
        public IEnumerable<PersonalBBP> GetPersonalBBP()
        {
            List<PersonalBBP> pbbp = new List<PersonalBBP>();
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            pbbp.Add(new PersonalBBP { App = "Carreño", Apm = "Nevarez", Nombre = "Gustavo", Sexo = "Macho", Puesto = "Peor es nada" });
            return pbbp.ToList();
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }

        public class PersonalBBP
        {
            public string Nombre { get; set; }
            public string App { get; set; }
            public string Apm { get; set; }
            public string Sexo { get; set; }
            public string Puesto { get; set; }
        }
    }
}
