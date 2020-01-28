using DDona.RefitTest.Domain.Entities;
using DDona.RefitTest.WebApiInterface;
using Refit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDona.RefitTest.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICorApi corApi = RestService.For<ICorApi>("https://localhost:44391");
            IEnumerable<Cor> cores = await corApi.CarregarTodos();

            foreach (var cor in cores)
            {
                Console.WriteLine(cor.ToString());
            }
        }
    }
}
