using Bankk2.Models;
using Microsoft.EntityFrameworkCore;
using Курсовая;

namespace Bankk2.SeedData
{
    public static class SeedData
    {

        //public static void Initialize(IServiceProvider serviceProvider)
        //{
        //    using (var context = new DataBaseContext(
        //        serviceProvider.GetRequiredService<
        //            DbContextOptions<DataBaseContext>>()))
        //    {
        //        if (context.DataCard.Any())
        //        {
        //            return;   // DB has been seeded
        //        }
        //        context.DataCard.AddRange(
        //            new DataCard
        //            {
        //                CardNumber = StaticDataCard.CardNumber,
        //                CVV = StaticDataCard.CVV,
        //                BeforeDate ="07/29",
        //                UserEmail = StaticDataCard.UserEmail
        //            }
        //        );
        //        context.SaveChanges();
        //    }
        //}

    }
}
