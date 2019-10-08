using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeeContext>>()))
            {
                // Look for any movies.
                if (context.Employees.Any())
                {
                    return;
                }
            }
        }
    }
}
