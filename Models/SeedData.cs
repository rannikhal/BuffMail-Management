using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BuffMail.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffMailDbContext(serviceProvider.GetRequiredService<DbContextOptions<BuffMailDbContext>>()))
            {
                string wt_email = "gkortizdejesus1@buffs.wtamu.edu"; // my school email to test emailing method

                Resident resident1 = new Resident
                {
                    Name = "Kittie Mousdall",
                    Email = wt_email,
                    UnitNumber = 101

                };

                Resident resident2 = new Resident
                {
                    Name = "Claudette Rait",
                    Email = wt_email,
                    UnitNumber = 102

                };

                Resident resident3 = new Resident
                {
                    Name = "Eliza Himsworth",
                    Email = wt_email,
                    UnitNumber = 103

                };

                Resident resident4 = new Resident
                {
                    Name = "Emmit Gann",
                    Email = wt_email,
                    UnitNumber = 104

                };

                Resident resident5 = new Resident
                {
                    Name = "Aurlie Pedycan",
                    Email = wt_email,
                    UnitNumber = 105

                };

                Resident resident6 = new Resident
                {
                    Name = "Keriann Kettlesting",
                    Email = wt_email,
                    UnitNumber = 106

                };

                Resident resident7 = new Resident
                {
                    Name = "Fiorenze Iacovuzzi",
                    Email = wt_email,
                    UnitNumber = 107

                };

                Resident resident8 = new Resident
                {
                    Name = "Darlene Gravie",
                    Email = wt_email,
                    UnitNumber = 108

                };

                Resident resident9 = new Resident
                {
                    Name = "Tomasine Challener",
                    Email = wt_email,
                    UnitNumber = 109

                };

                Resident resident10 = new Resident
                {
                    Name = "Dotti Marple",
                    Email = wt_email,
                    UnitNumber = 110

                };

                Resident resident11 = new Resident
                {
                    Name = "Gabriel Tofanelli",
                    Email = wt_email,
                    UnitNumber = 201

                };

                Resident resident12 = new Resident
                {
                    Name = "Aldo Welldrake",
                    Email = wt_email,
                    UnitNumber = 202

                };

                Resident resident13 = new Resident
                {
                    Name = "Ezmeralda Laydon",
                    Email = wt_email,
                    UnitNumber = 203

                };

                Resident resident14 = new Resident
                {
                    Name = "Kale Lendrem",
                    Email = wt_email,
                    UnitNumber = 204

                };

                Resident resident15 = new Resident
                {
                    Name = "Lenard Cubbit",
                    Email = wt_email,
                    UnitNumber = 205

                };

                Resident resident16 = new Resident
                {
                    Name = "Dedie Caddies",
                    Email = wt_email,
                    UnitNumber = 206

                };

                Resident resident17 = new Resident
                {
                    Name = "Nancy Janosevic",
                    Email = wt_email,
                    UnitNumber = 207

                };

                Resident resident18 = new Resident
                {
                    Name = "Layne Whiterod",
                    Email = wt_email,
                    UnitNumber = 208

                };

                Resident resident19 = new Resident
                {
                    Name = "Averell Labusch",
                    Email = wt_email,
                    UnitNumber = 209

                };

                Resident resident20 = new Resident
                {
                    Name = "Gordan Raddon",
                    Email = wt_email,
                    UnitNumber = 210

                };

                Resident resident21 = new Resident
                {
                    Name = "Deloria Johnes",
                    Email = wt_email,
                    UnitNumber = 301

                };

                Resident resident22 = new Resident
                {
                    Name = "Emmett MacIllrick",
                    Email = wt_email,
                    UnitNumber = 302

                };

                Resident resident23 = new Resident
                {
                    Name = "Sanderson Simoncelli",
                    Email = wt_email,
                    UnitNumber = 303

                };

                Resident resident24 = new Resident
                {
                    Name = "Had Hapke",
                    Email = wt_email,
                    UnitNumber = 304

                };

                Resident resident25 = new Resident
                {
                    Name = "Bellina Rodenburgh",
                    Email = wt_email,
                    UnitNumber = 305

                };

                Resident resident26 = new Resident
                {
                    Name = "Portie Searle",
                    Email = wt_email,
                    UnitNumber = 306

                };

                Resident resident27 = new Resident
                {
                    Name = "Ellsworth Richichi",
                    Email = wt_email,
                    UnitNumber = 307

                };

                Resident resident28 = new Resident
                {
                    Name = "Orlando Mattholie",
                    Email = wt_email,
                    UnitNumber = 308

                };

                Resident resident29 = new Resident
                {
                    Name = "Noby Phelp",
                    Email = wt_email,
                    UnitNumber = 309

                };

                Resident resident30 = new Resident
                {
                    Name = "Wilow Caush",
                    Email = wt_email,
                    UnitNumber = 310

                };

                Resident resident31 = new Resident
                {
                    Name = "Hesther Wincom",
                    Email = wt_email,
                    UnitNumber = 401

                };

                Resident resident32 = new Resident
                {
                    Name = "Ferdie Jzhakov",
                    Email = wt_email,
                    UnitNumber = 402

                };

                Resident resident33 = new Resident
                {
                    Name = "Cornelia Burlingham",
                    Email = wt_email,
                    UnitNumber = 403

                };

                Resident resident34 = new Resident
                {
                    Name = "Rochella Childers",
                    Email = wt_email,
                    UnitNumber = 404

                };

                Resident resident35 = new Resident
                {
                    Name = "Jennie Christensen",
                    Email = wt_email,
                    UnitNumber = 405

                };

                Resident resident36 = new Resident
                {
                    Name = "Kalie Cropper",
                    Email = wt_email,
                    UnitNumber = 406

                };

                Resident resident37 = new Resident
                {
                    Name = "Corinne Garrison",
                    Email = wt_email,
                    UnitNumber = 407

                };

                Resident resident38 = new Resident
                {
                    Name = "Maybelle Pigne",
                    Email = wt_email,
                    UnitNumber = 408

                };

                Resident resident39 = new Resident
                {
                    Name = "Wald Kuddyhy",
                    Email = wt_email,
                    UnitNumber = 409

                };

                Resident resident40 = new Resident
                {
                    Name = "Blancha Ambrosoni",
                    Email = wt_email,
                    UnitNumber = 410

                };

                Resident resident41 = new Resident
                {
                    Name = "Gussy Moiser",
                    Email = wt_email,
                    UnitNumber = 501

                };

                Resident resident42 = new Resident
                {
                    Name = "Margette Symcock",
                    Email = wt_email,
                    UnitNumber = 502

                };

                Resident resident43 = new Resident
                {
                    Name = "Cad Stearnes",
                    Email = wt_email,
                    UnitNumber = 503

                };

                Resident resident44 = new Resident
                {
                    Name = "Juliann Sumner",
                    Email = wt_email,
                    UnitNumber = 504

                };

                Resident resident45 = new Resident
                {
                    Name = "Esdras Bresland",
                    Email = wt_email,
                    UnitNumber = 505

                };

                Resident resident46 = new Resident
                {
                    Name = "Alisha Laspee",
                    Email = wt_email,
                    UnitNumber = 506

                };

                Resident resident47 = new Resident
                {
                    Name = "Yvon Jirusek",
                    Email = wt_email,
                    UnitNumber = 507

                };

                Resident resident48 = new Resident
                {
                    Name = "Parrnell Halbeard",
                    Email = wt_email,
                    UnitNumber = 508

                };

                Resident resident49 = new Resident
                {
                    Name = "Korrie Milesap",
                    Email = wt_email,
                    UnitNumber = 509

                };

                Resident resident50 = new Resident
                {
                    Name = "Vivyan Petzold",
                    Email = wt_email,
                    UnitNumber = 510

                };

                Resident resident51 = new Resident
                {
                    Name = "Angie Darben",
                    Email = wt_email,
                    UnitNumber = 101

                };

                Resident resident52 = new Resident
                {
                    Name = "Eachelle Texton",
                    Email = wt_email,
                    UnitNumber = 102

                };

                Resident resident53 = new Resident
                {
                    Name = "Lion Imlaw",
                    Email = wt_email,
                    UnitNumber = 103

                };

                Resident resident54 = new Resident
                {
                    Name = "Delmore Cowhig",
                    Email = wt_email,
                    UnitNumber = 104

                };

                Resident resident55 = new Resident
                {
                    Name = "Shaine Van Kruis",
                    Email = wt_email,
                    UnitNumber = 105

                };

                Resident resident56 = new Resident
                {
                    Name = "Yehudi Jones",
                    Email = wt_email,
                    UnitNumber = 106

                };

                Resident resident57 = new Resident
                {
                    Name = "Hamlen Gerrad",
                    Email = wt_email,
                    UnitNumber = 107

                };

                Resident resident58 = new Resident
                {
                    Name = "Elisabetta Francescozzi",
                    Email = wt_email,
                    UnitNumber = 108

                };

                Resident resident59 = new Resident
                {
                    Name = "Gusti Chinn",
                    Email = wt_email,
                    UnitNumber = 109

                };

                Resident resident60 = new Resident
                {
                    Name = "Candace Hurlston",
                    Email = wt_email,
                    UnitNumber = 110

                };

                Resident resident61 = new Resident
                {
                    Name = "Odey Butter",
                    Email = wt_email,
                    UnitNumber = 201

                };

                Resident resident62 = new Resident
                {
                    Name = "Viva Bolletti",
                    Email = wt_email,
                    UnitNumber = 202

                };

                Resident resident63 = new Resident
                {
                    Name = "Tallie Jubert",
                    Email = wt_email,
                    UnitNumber = 203

                };

                Resident resident64 = new Resident
                {
                    Name = "Mary Vearnals",
                    Email = wt_email,
                    UnitNumber = 204

                };

                Resident resident65 = new Resident
                {
                    Name = "Lona Dunbavin",
                    Email = wt_email,
                    UnitNumber = 205

                };

                Resident resident66 = new Resident
                {
                    Name = "Osmond Bamlett",
                    Email = wt_email,
                    UnitNumber = 206

                };

                Resident resident67 = new Resident
                {
                    Name = "Nomi Sollom",
                    Email = wt_email,
                    UnitNumber = 207

                };

                Resident resident68 = new Resident
                {
                    Name = "Hildy Campana",
                    Email = wt_email,
                    UnitNumber = 208

                };

                Resident resident69 = new Resident
                {
                    Name = "Emmanuel Getcliffe",
                    Email = wt_email,
                    UnitNumber = 209

                };

                Resident resident70 = new Resident
                {
                    Name = "Danette Danieli",
                    Email = wt_email,
                    UnitNumber = 210

                };

                Resident resident71 = new Resident
                {
                    Name = "Jan Witt",
                    Email = wt_email,
                    UnitNumber = 301

                };

                Resident resident72 = new Resident
                {
                    Name = "Woodie Kertess",
                    Email = wt_email,
                    UnitNumber = 302

                };

                Resident resident73 = new Resident
                {
                    Name = "Corine Cleevely",
                    Email = wt_email,
                    UnitNumber = 303

                };

                Resident resident74 = new Resident
                {
                    Name = "Inez Mew",
                    Email = wt_email,
                    UnitNumber = 304

                };

                Resident resident75 = new Resident
                {
                    Name = "Kathie Odd",
                    Email = wt_email,
                    UnitNumber = 305

                };

                Resident resident76 = new Resident
                {
                    Name = "Mitch Friedlos",
                    Email = wt_email,
                    UnitNumber = 306

                };

                Resident resident77 = new Resident
                {
                    Name = "Bambi Gostick",
                    Email = wt_email,
                    UnitNumber = 307

                };

                Resident resident78 = new Resident
                {
                    Name = "Mellicent Roiz",
                    Email = wt_email,
                    UnitNumber = 308

                };

                Resident resident79 = new Resident
                {
                    Name = "Sukey Avon",
                    Email = wt_email,
                    UnitNumber = 309

                };

                Resident resident80 = new Resident
                {
                    Name = "Janina Kernan",
                    Email = wt_email,
                    UnitNumber = 310

                };

                Resident resident81 = new Resident
                {
                    Name = "Jaynell Pitfield",
                    Email = wt_email,
                    UnitNumber = 401

                };

                Resident resident82 = new Resident
                {
                    Name = "Ricki Hoppner",
                    Email = wt_email,
                    UnitNumber = 402

                };

                Resident resident83 = new Resident
                {
                    Name = "Rinaldo Stable",
                    Email = wt_email,
                    UnitNumber = 403

                };

                Resident resident84 = new Resident
                {
                    Name = "Tessy Tabour",
                    Email = wt_email,
                    UnitNumber = 404

                };

                Resident resident85 = new Resident
                {
                    Name = "Helen Ferencz",
                    Email = wt_email,
                    UnitNumber = 405

                };

                Resident resident86 = new Resident
                {
                    Name = "Korney Shakelade",
                    Email = wt_email,
                    UnitNumber = 406

                };

                Resident resident87 = new Resident
                {
                    Name = "Tulley Reiner",
                    Email = wt_email,
                    UnitNumber = 407

                };

                Resident resident88 = new Resident
                {
                    Name = "Myrle Mersh",
                    Email = wt_email,
                    UnitNumber = 408

                };

                Resident resident89 = new Resident
                {
                    Name = "Carina Nelthorp",
                    Email = wt_email,
                    UnitNumber = 409

                };

                Resident resident90 = new Resident
                {
                    Name = "Monte Trahmel",
                    Email = wt_email,
                    UnitNumber = 410

                };

                Resident resident91 = new Resident
                {
                    Name = "Nate Zavattero",
                    Email = wt_email,
                    UnitNumber = 501

                };

                Resident resident92 = new Resident
                {
                    Name = "Neddy Bucky",
                    Email = wt_email,
                    UnitNumber = 502

                };

                Resident resident93 = new Resident
                {
                    Name = "Allissa Collyns",
                    Email = wt_email,
                    UnitNumber = 503

                };

                Resident resident94 = new Resident
                {
                    Name = "Brianna Ruberry",
                    Email = wt_email,
                    UnitNumber = 504

                };

                Resident resident95 = new Resident
                {
                    Name = "Roxane Wellen",
                    Email = wt_email,
                    UnitNumber = 505

                };

                Resident resident96 = new Resident
                {
                    Name = "Ashbey Keddy",
                    Email = wt_email,
                    UnitNumber = 506

                };

                Resident resident97 = new Resident
                {
                    Name = "Elvin Mico",
                    Email = wt_email,
                    UnitNumber = 507

                };

                Resident resident98 = new Resident
                {
                    Name = "Nicolas Hanratty",
                    Email = wt_email,
                    UnitNumber = 508

                };

                Resident resident99 = new Resident
                {
                    Name = "Gary Jochens",
                    Email = wt_email,
                    UnitNumber = 509

                };

                Resident resident100 = new Resident
                {
                    Name = "Alexina Tarbard",
                    Email = wt_email,
                    UnitNumber = 510

                };

                Staff staff1 = new Staff
                {
                    Username = "alice",
                    Password = "alice123"
                };

                Staff staff2 = new Staff
                {
                    Username = "bob",
                    Password = "bob123"
                };
            }
        }
    }
}