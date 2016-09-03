using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderRevised.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BartenderRevisedEntities>
    {
        protected override void Seed(BartenderRevisedEntities context)
        {
            var types = new List<DrinkType>
            {
                new DrinkType { Name = "Beer" },
                new DrinkType { Name = "Wine" },
                new DrinkType { Name = "Liquor" },
                
            };

            new List<Brand>
            {
                new Brand { Title = "Corona", DrinkType = types.Single(g => g.Name == "Beer"), Price = 4.99M, BrandID = 1},
                new Brand { Title = "Blue Moon", DrinkType = types.Single(g => g.Name == "Beer"), Price = 5.99M, BrandID = 2},
                new Brand { Title = "Woodbridge", DrinkType = types.Single(g => g.Name == "Wine"), Price = 7.99M, BrandID = 3},
                new Brand { Title = "3 Wishes", DrinkType = types.Single(g => g.Name == "Wine"), Price = 6.99M, BrandID = 4},
                new Brand { Title = "Balls to the Wall", DrinkType = types.Single(g => g.Name == "Liquor"), Price = 8.99M, BrandID = 5},
                new Brand { Title = "Restless and Wild", DrinkType = types.Single(g => g.Name == "Liquor"), Price = 8.99M, BrandID = 5},
            }.ForEach(g => context.Brands.Add(g));
        }
    }
}