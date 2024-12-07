using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using BuffMail.Models;

namespace BuffMail.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffMailDbContext(serviceProvider.GetRequiredService<DbContextOptions<BuffMailDbContext>>()))
            {
                string wt_email = "gkortizdejesus1@buffs.wtamu.edu"; // my school email to test emailing method
                
                // if there are no records in Staff, it seeds data
                if (!context.Staff.Any())
                {
                    context.Staff.AddRange(
                        new Staff {Username = "alice", Password = "alice123"},
                        new Staff {Username = "bob", Password = "bob123"}
                    );
                }

                // if there are no records in Resident, it seeds data
                if (!context.Resident.Any())
                {
                    context.Resident.AddRange(
                        new Resident {Name = "Kittie Mousdall", Email = wt_email, UnitNumber = 101},
                        new Resident {Name = "Claudette Rait", Email = wt_email, UnitNumber = 102},
                        new Resident {Name = "Eliza Himsworth", Email = wt_email, UnitNumber = 103},
                        new Resident {Name = "Emmit Gann", Email = wt_email, UnitNumber = 104},
                        new Resident {Name = "Aurlie Pedycan",Email = wt_email, UnitNumber = 105},
                        new Resident {Name = "Keriann Kettlesting", Email = wt_email, UnitNumber = 106},
                        new Resident {Name = "Fiorenze Iacovuzzi", Email = wt_email, UnitNumber = 107},
                        new Resident {Name = "Darlene Gravie", Email = wt_email, UnitNumber = 108},
                        new Resident {Name = "Tomasine Challener", Email = wt_email, UnitNumber = 109},
                        new Resident {Name = "Dotti Marple", Email = wt_email, UnitNumber = 110},
                        new Resident {Name = "Gabriel Tofanelli", Email = wt_email, UnitNumber = 201},
                        new Resident {Name = "Aldo Welldrake", Email = wt_email, UnitNumber = 202},
                        new Resident {Name = "Ezmeralda Laydon", Email = wt_email, UnitNumber = 203},
                        new Resident {Name = "Kale Lendrem", Email = wt_email, UnitNumber = 204},
                        new Resident {Name = "Lenard Cubbit", Email = wt_email, UnitNumber = 205},
                        new Resident {Name = "Dedie Caddies", Email = wt_email, UnitNumber = 206},
                        new Resident {Name = "Nancy Janosevic", Email = wt_email, UnitNumber = 207},
                        new Resident {Name = "Layne Whiterod", Email = wt_email, UnitNumber = 208},
                        new Resident {Name = "Averell Labusch", Email = wt_email, UnitNumber = 209},
                        new Resident {Name = "Gordan Raddon", Email = wt_email, UnitNumber = 210},
                        new Resident {Name = "Deloria Johnes", Email = wt_email, UnitNumber = 301},
                        new Resident {Name = "Emmett MacIllrick", Email = wt_email, UnitNumber = 302},
                        new Resident {Name = "Sanderson Simoncelli", Email = wt_email, UnitNumber = 303},
                        new Resident {Name = "Had Hapke", Email = wt_email, UnitNumber = 304},
                        new Resident {Name = "Bellina Rodenburgh", Email = wt_email, UnitNumber = 305},
                        new Resident {Name = "Portie Searle", Email = wt_email, UnitNumber = 306},
                        new Resident {Name = "Ellsworth Richichi", Email = wt_email, UnitNumber = 307},
                        new Resident {Name = "Orlando Mattholie", Email = wt_email, UnitNumber = 308},
                        new Resident {Name = "Noby Phelp", Email = wt_email, UnitNumber = 309},
                        new Resident {Name = "Wilow Caush", Email = wt_email, UnitNumber = 310},
                        new Resident {Name = "Hesther Wincom", Email = wt_email, UnitNumber = 401},
                        new Resident {Name = "Ferdie Jzhakov", Email = wt_email, UnitNumber = 402},
                        new Resident {Name = "Cornelia Burlingham", Email = wt_email, UnitNumber = 403},
                        new Resident {Name = "Rochella Childers", Email = wt_email, UnitNumber = 404},
                        new Resident {Name = "Jennie Christensen", Email = wt_email, UnitNumber = 405},
                        new Resident {Name = "Kalie Cropper", Email = wt_email, UnitNumber = 406},
                        new Resident {Name = "Corinne Garrison", Email = wt_email, UnitNumber = 407},
                        new Resident {Name = "Maybelle Pigne", Email = wt_email, UnitNumber = 408},
                        new Resident {Name = "Wald Kuddyhy", Email = wt_email, UnitNumber = 409},
                        new Resident {Name = "Blancha Ambrosoni", Email = wt_email, UnitNumber = 410},
                        new Resident {Name = "Gussy Moiser", Email = wt_email, UnitNumber = 501},
                        new Resident {Name = "Margette Symcock", Email = wt_email, UnitNumber = 502},
                        new Resident {Name = "Cad Stearnes", Email = wt_email, UnitNumber = 503},
                        new Resident {Name = "Juliann Sumner", Email = wt_email, UnitNumber = 504},
                        new Resident {Name = "Esdras Bresland", Email = wt_email, UnitNumber = 505},
                        new Resident {Name = "Alisha Laspee", Email = wt_email, UnitNumber = 506},
                        new Resident {Name = "Yvon Jirusek", Email = wt_email, UnitNumber = 507},
                        new Resident {Name = "Parrnell Halbeard", Email = wt_email, UnitNumber = 508},
                        new Resident {Name = "Korrie Milesap", Email = wt_email, UnitNumber = 509},
                        new Resident {Name = "Vivyan Petzold", Email = wt_email, UnitNumber = 510},
                        new Resident {Name = "Angie Darben", Email = wt_email, UnitNumber = 101},
                        new Resident {Name = "Eachelle Texton", Email = wt_email, UnitNumber = 102},
                        new Resident {Name = "Lion Imlaw", Email = wt_email, UnitNumber = 103},
                        new Resident {Name = "Delmore Cowhig", Email = wt_email, UnitNumber = 104},
                        new Resident {Name = "Shaine Van Kruis", Email = wt_email, UnitNumber = 105},
                        new Resident {Name = "Yehudi Jones", Email = wt_email, UnitNumber = 106},
                        new Resident {Name = "Hamlen Gerrad", Email = wt_email, UnitNumber = 107},
                        new Resident {Name = "Elisabetta Francescozzi", Email = wt_email, UnitNumber = 108},
                        new Resident {Name = "Gusti Chinn", Email = wt_email, UnitNumber = 109},
                        new Resident {Name = "Candace Hurlston", Email = wt_email, UnitNumber = 110},
                        new Resident {Name = "Odey Butter", Email = wt_email, UnitNumber = 201},
                        new Resident {Name = "Viva Bolletti", Email = wt_email, UnitNumber = 202},
                        new Resident {Name = "Tallie Jubert", Email = wt_email, UnitNumber = 203},
                        new Resident {Name = "Mary Vearnals", Email = wt_email, UnitNumber = 204},
                        new Resident {Name = "Lona Dunbavin", Email = wt_email, UnitNumber = 205},
                        new Resident {Name = "Osmond Bamlett", Email = wt_email, UnitNumber = 206},
                        new Resident {Name = "Nomi Sollom", Email = wt_email, UnitNumber = 207},
                        new Resident {Name = "Hildy Campana", Email = wt_email, UnitNumber = 208},
                        new Resident {Name = "Emmanuel Getcliffe", Email = wt_email, UnitNumber = 209},
                        new Resident {Name = "Danette Danieli", Email = wt_email, UnitNumber = 210},
                        new Resident {Name = "Jan Witt", Email = wt_email, UnitNumber = 301},
                        new Resident {Name = "Woodie Kertess", Email = wt_email, UnitNumber = 302},
                        new Resident {Name = "Corine Cleevely", Email = wt_email, UnitNumber = 303},
                        new Resident {Name = "Inez Mew", Email = wt_email, UnitNumber = 304},
                        new Resident {Name = "Kathie Odd", Email = wt_email, UnitNumber = 305},
                        new Resident {Name = "Mitch Friedlos", Email = wt_email, UnitNumber = 306},
                        new Resident {Name = "Bambi Gostick", Email = wt_email, UnitNumber = 307},
                        new Resident {Name = "Mellicent Roiz", Email = wt_email, UnitNumber = 308},
                        new Resident {Name = "Sukey Avon", Email = wt_email, UnitNumber = 309},
                        new Resident {Name = "Janina Kernan", Email = wt_email, UnitNumber = 310},
                        new Resident {Name = "Jaynell Pitfield", Email = wt_email, UnitNumber = 401},
                        new Resident {Name = "Ricki Hoppner", Email = wt_email, UnitNumber = 402},
                        new Resident {Name = "Rinaldo Stable", Email = wt_email, UnitNumber = 403},
                        new Resident {Name = "Tessy Tabour", Email = wt_email, UnitNumber = 404},
                        new Resident {Name = "Helen Ferencz", Email = wt_email, UnitNumber = 405},
                        new Resident {Name = "Korney Shakelade", Email = wt_email, UnitNumber = 406},
                        new Resident {Name = "Tulley Reiner", Email = wt_email, UnitNumber = 407},
                        new Resident {Name = "Myrle Mersh", Email = wt_email, UnitNumber = 408},
                        new Resident {Name = "Carina Nelthorp", Email = wt_email, UnitNumber = 409},
                        new Resident {Name = "Monte Trahmel", Email = wt_email, UnitNumber = 410},
                        new Resident {Name = "Nate Zavattero", Email = wt_email, UnitNumber = 501},
                        new Resident {Name = "Neddy Bucky", Email = wt_email, UnitNumber = 502},
                        new Resident {Name = "Allissa Collyns", Email = wt_email, UnitNumber = 503},
                        new Resident {Name = "Brianna Ruberry", Email = wt_email, UnitNumber = 504},
                        new Resident {Name = "Roxane Wellen", Email = wt_email, UnitNumber = 505},
                        new Resident {Name = "Ashbey Keddy", Email = wt_email, UnitNumber = 506},
                        new Resident {Name = "Elvin Mico", Email = wt_email, UnitNumber = 507},
                        new Resident {Name = "Nicolas Hanratty", Email = wt_email, UnitNumber = 508},
                        new Resident {Name = "Gary Jochens", Email = wt_email, UnitNumber = 509},
                        new Resident {Name = "Alexina Tarbard", Email = wt_email, UnitNumber = 510}
                    );
                }

                context.SaveChanges();
            }
        }
    }
}