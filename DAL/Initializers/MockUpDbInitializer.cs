using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
using Enums;
using System.Data.Entity.Migrations;

namespace DAL.Initializers
{
    class MockUpDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region Seeding Genres
            Genre g1 = new Genre(GenreType.Action_Adventure);
            Genre g2 = new Genre(GenreType.Fighting);
            Genre g3 = new Genre(GenreType.FPS);
            Genre g4 = new Genre(GenreType.Horror);
            Genre g5 = new Genre(GenreType.MMORPG);
            Genre g6 = new Genre(GenreType.Open_World);
            Genre g7 = new Genre(GenreType.Puzzle);
            Genre g8 = new Genre(GenreType.RPG);
            Genre g9 = new Genre(GenreType.SciFi);
            Genre g10 = new Genre(GenreType.Strategy);
            Genre g11 = new Genre(GenreType.Survival);
            Genre g12 = new Genre(GenreType.Stealth);
            Genre g13 = new Genre(GenreType.Hack_and_Slash);

            context.Genres.AddOrUpdate(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11);
            context.SaveChanges();
            #endregion

            #region Seeding Platforms
            Platform p1 = new Platform(PlatformName.PC);
            Platform p2 = new Platform(PlatformName.PS);
            Platform p3 = new Platform(PlatformName.PS2);
            Platform p4 = new Platform(PlatformName.PS3);
            Platform p5 = new Platform(PlatformName.PS4);
            Platform p6 = new Platform(PlatformName.PSP);
            Platform p7 = new Platform(PlatformName.PS5);
            Platform p8 = new Platform(PlatformName.Xbox);
            Platform p9 = new Platform(PlatformName.Xbox_360);
            Platform p10 = new Platform(PlatformName.Xbox_One);
            Platform p11 = new Platform(PlatformName.Xbox_Series_X);
            Platform p12 = new Platform(PlatformName.Nintendo_Gameboy);
            Platform p13 = new Platform(PlatformName.Nintendo_Gameboy_Advanced);
            Platform p14 = new Platform(PlatformName.Nintendo_Sp);
            Platform p15 = new Platform(PlatformName.Nintendo_Ds);
            Platform p16 = new Platform(PlatformName.Nintendo_Wii);
            Platform p17 = new Platform(PlatformName.Nintendo_Wii_U);
            Platform p18 = new Platform(PlatformName.Nintendo_Switch);

            context.Platforms.AddOrUpdate(p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18);
            context.SaveChanges();
            #endregion

            #region Seeding Videogames
            Videogame v1 = new Videogame("Bloodborne", "https://assets.reedpopcdn.com/-1616688899670.jpg/BROK/thumbnail/1200x1200/quality/100/-1616688899670.jpg", 9.2, 8.9, "https://www.youtube.com/watch?v=G203e1HhixY", 9.99, PegiAgeRating.Pegi18, new DateTime(2015, 3, 15));
            Videogame v2 = new Videogame("Sekiro", "https://image.api.playstation.com/vulcan/img/rnd/202010/2723/knxU5uU5aKvQChKX5OvWtSGC.png", 8.8, 9.5, "https://www.youtube.com/watch?v=4OgoTZXPACo", 59.99, PegiAgeRating.Pegi18, new DateTime(2019, 3, 21));
            Videogame v3 = new Videogame("Assassin's Creed", "https://www.thathashtagshow.com/wp-content/uploads/2021/04/Accover.jpg", 8.1, 7.6, "https://www.youtube.com/watch?v=RjQ6ZtyXoA0&t=36s", 19.99, PegiAgeRating.Pegi16, new DateTime(2009, 4, 8));
            Videogame v4 = new Videogame("Assassin's Creed 2", "https://static.wikia.nocookie.net/assassinscreed/images/0/09/AC2coverHighRes.jpg", 8.9, 8.7, "https://www.youtube.com/watch?v=_xkCPNECud8", 9.99, PegiAgeRating.Pegi18, new DateTime(2009, 11, 17));
            Videogame v5 = new Videogame("Assassin's Creed Brotherhood", "https://img.elo7.com.br/product/zoom/256E49E/big-poster-gamer-assassins-creed-brotherhood-03-tam-90x60-cm-geek.jpg", 9.0, 8.3, "https://www.youtube.com/watch?v=zzNs4-kRLaE", 18.99, PegiAgeRating.Pegi18, new DateTime(2010, 11, 16));
            Videogame v6 = new Videogame("Assassin's Creed Revelations", "https://m.media-amazon.com/images/M/MV5BYTdkN2I5NDgtNmEwNy00ZmRlLWI2ZjMtYzAzZDMxY2FjZjY4XkEyXkFqcGdeQXVyMjM5NzU3OTM@._V1_.jpg", 8.0, 7.6, "https://www.youtube.com/watch?v=8-Ixo7QXw_E", 16.99, PegiAgeRating.Pegi18, new DateTime(2011, 12, 15));
            Videogame v7 = new Videogame("Assassin's Creed 3", "https://cdn-products.eneba.com/resized-products/reSSOeBp-jORO_ZkfdhCN3ta1k0xniJs3On3m8Fr3Z4_350x200_3x-0.jpeg", 8.0, 6.4, "https://www.youtube.com/watch?v=-pUhraVG7Ow", 39.99, PegiAgeRating.Pegi18, new DateTime(2012, 10, 30));
            Videogame v8 = new Videogame("Assassin's Creed Black Flag", "https://cdn-products.eneba.com/resized-products/vqv03fmtmnvnvlolm6b5_350x200_3x-0.jpg", 8.4, 8.0, "https://www.youtube.com/watch?v=WdKIQSwkYHI", 11.99, PegiAgeRating.Pegi18, new DateTime(2013, 10, 29));
            Videogame v9 = new Videogame("Assassin's Creed Unity", "https://i.gadgets360cdn.com/products/large/assassin-s-creed-unity-cover-i22385-1000x1500-1656306969.jpg", 7.0, 5.8, "https://www.youtube.com/watch?v=xzCEdSKMkdU", 29.99, PegiAgeRating.Pegi18, new DateTime(2014, 11, 11));
            Videogame v10 = new Videogame("Assassin's Creed Origins", "https://cdn1.epicgames.com/undefined/offer/S2_ACOD-1280x1440-621a727d381ffe0cffe869c1e23bc741.jpg", 8.4, 6.9, "https://www.youtube.com/watch?v=cK4iAjzAoas", 13.99, PegiAgeRating.Pegi18, new DateTime(2017, 10, 27));
            Videogame v11 = new Videogame("Assassin's Creed Odyssey", "https://mir-s3-cdn-cf.behance.net/project_modules/1400/c48e1167302871.5ba4cb894788a.jpg", 8.5, 6.3, "https://www.youtube.com/watch?v=s_SJZSAtLBA", 17.99, PegiAgeRating.Pegi18, new DateTime(2018, 11, 2));
            Videogame v12 = new Videogame("Assassin's Creed Valhalla", "https://image.api.playstation.com/vulcan/ap/rnd/202008/1318/8XGEPtD1xoasK0FYkYNcCn1z.png", 8.2, 7.5, "https://www.youtube.com/watch?v=ssrNcwxALS", 27.99, PegiAgeRating.Pegi18, new DateTime(2020, 11, 10));
            Videogame v13 = new Videogame("Dark Souls", "https://pbs.twimg.com/media/ExCXIoAXMAszkdA.jpg", 8.4, 8.1, "https://www.youtube.com/watch?v=o1780AqAa20", 19.99, PegiAgeRating.Pegi16, new DateTime(2011, 9, 22));
            Videogame v14 = new Videogame("Dark Souls 2", "https://www.mobygames.com/images/covers/l/637472-dark-souls-ii-black-armour-edition-playstation-3-manual.jpg", 9.1, 7.2, "https://www.youtube.com/watch?v=U6uyuIQYlfY", 29.99, PegiAgeRating.Pegi16, new DateTime(2014, 3, 11));
            Videogame v15 = new Videogame("Dark Souls 3", "https://image.api.playstation.com/cdn/EP0700/CUSA03365_00/OFMeAw2KhrdaEZAjW1f3tCIXbogkLpTC.png", 8.9, 8.6, "https://www.youtube.com/watch?v=cWBwFhUv1-8", 14.99, PegiAgeRating.Pegi16, new DateTime(2016, 3, 24));
            Videogame v16 = new Videogame("God of War", "https://romspure.cc/wp-content/uploads/2020/05/1589188213-20b1d104-2b5f-41d3-bbb7-4fa9deb642d7.png", 9.4, 8.9, "https://www.youtube.com/watch?v=jZkX3LJDeYQ", 9.40, PegiAgeRating.Pegi18, new DateTime(2005, 3, 22));
            Videogame v17 = new Videogame("God of War 2", "https://pbs.twimg.com/media/FNOeiCPVgAA8KQP.jpg", 9.3, 9.0, "https://www.youtube.com/watch?v=HhpqvmKZDDM", 13.54, PegiAgeRating.Pegi18, new DateTime(2007, 3, 13));
            Videogame v18 = new Videogame("God of War 3", "https://assets-prd.ignimgs.com/2022/01/07/god-of-war-3-button-1641590938804.jpg", 9.2, 8.8, "https://www.youtube.com/watch?v=qKogMfIAAkY", 7.99, PegiAgeRating.Pegi18, new DateTime(2010, 3, 16));

            context.VideoGames.AddOrUpdate(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15,v16,v17,v18);
            context.SaveChanges();
            #endregion

            #region Seeding Platforms and Genres
            v1.Platforms.Add(p5);
            v1.Genres.Add(g1);
            v1.Genres.Add(g4);
            v1.Genres.Add(g6);
            v1.Genres.Add(g8);
            v1.Genres.Add(g13);


            v2.Platforms.Add(p1);
            v2.Platforms.Add(p5);
            v2.Platforms.Add(p10);
            v2.Genres.Add(g1);
            v2.Genres.Add(g8);


            v3.Platforms.Add(p1);
            v3.Platforms.Add(p4);
            v3.Platforms.Add(p9);
            v3.Genres.Add(g1);
            v3.Genres.Add(g6);
            v3.Genres.Add(g12);

            v4.Platforms.Add(p1);
            v4.Platforms.Add(p4);
            v4.Platforms.Add(p5);
            v4.Platforms.Add(p9);
            v4.Platforms.Add(p10);
            v4.Platforms.Add(p18);
            v4.Genres.Add(g1);
            v4.Genres.Add(g6);
            v4.Genres.Add(g12);

            v5.Platforms.Add(p1);
            v5.Platforms.Add(p4);
            v5.Platforms.Add(p5);
            v5.Platforms.Add(p9);
            v5.Platforms.Add(p10);
            v5.Platforms.Add(p18);
            v5.Genres.Add(g1);
            v5.Genres.Add(g6);
            v5.Genres.Add(g12);

            v6.Platforms.Add(p1);
            v6.Platforms.Add(p4);
            v6.Platforms.Add(p5);
            v6.Platforms.Add(p9);
            v6.Platforms.Add(p10);
            v6.Platforms.Add(p18);
            v6.Genres.Add(g1);
            v6.Genres.Add(g6);
            v6.Genres.Add(g12);

            v7.Platforms.Add(p1);
            v7.Platforms.Add(p4);
            v7.Platforms.Add(p5);
            v7.Platforms.Add(p9);
            v7.Platforms.Add(p10);
            v7.Platforms.Add(p17);
            v7.Platforms.Add(p18);
            v7.Genres.Add(g1);
            v7.Genres.Add(g6);
            v7.Genres.Add(g12);

            v8.Platforms.Add(p1);
            v8.Platforms.Add(p4);
            v8.Platforms.Add(p5);
            v8.Platforms.Add(p9);
            v8.Platforms.Add(p10);
            v8.Platforms.Add(p17);
            v8.Platforms.Add(p18);
            v8.Genres.Add(g1);
            v8.Genres.Add(g6);
            v8.Genres.Add(g12);

            v9.Platforms.Add(p1);
            v9.Platforms.Add(p5);
            v9.Platforms.Add(p10);
            v9.Genres.Add(g1);
            v9.Genres.Add(g6);
            v9.Genres.Add(g12);

            v10.Platforms.Add(p1);
            v10.Platforms.Add(p5);
            v10.Platforms.Add(p10);
            v10.Genres.Add(g1);
            v10.Genres.Add(g6);
            v10.Genres.Add(g8);

            v11.Platforms.Add(p1);
            v11.Platforms.Add(p5);
            v11.Platforms.Add(p10);
            v11.Platforms.Add(p18);
            v11.Genres.Add(g1);
            v11.Genres.Add(g6);
            v11.Genres.Add(g8);

            v12.Platforms.Add(p1);
            v12.Platforms.Add(p5);
            v12.Platforms.Add(p7);
            v12.Platforms.Add(p10);
            v12.Platforms.Add(p11);
            v12.Genres.Add(g1);
            v12.Genres.Add(g6);
            v12.Genres.Add(g8);

            v13.Platforms.Add(p1);
            v13.Platforms.Add(p4);
            v13.Platforms.Add(p5);
            v13.Platforms.Add(p9);
            v13.Platforms.Add(p10);
            v13.Platforms.Add(p18);
            v13.Genres.Add(g1);
            v13.Genres.Add(g6);
            v13.Genres.Add(g8);
            v13.Genres.Add(g13);

            v14.Platforms.Add(p1);
            v14.Platforms.Add(p4);
            v14.Platforms.Add(p5);
            v14.Platforms.Add(p9);
            v14.Platforms.Add(p10);
            v14.Genres.Add(g1);
            v14.Genres.Add(g6);
            v14.Genres.Add(g8);
            v14.Genres.Add(g13);

            v15.Platforms.Add(p1);
            v15.Platforms.Add(p5);
            v15.Platforms.Add(p10);
            v15.Genres.Add(g1);
            v15.Genres.Add(g6);
            v15.Genres.Add(g8);
            v15.Genres.Add(g13);

            v16.Platforms.Add(p3);
            v16.Genres.Add(g1);
            v16.Genres.Add(g13);

            v17.Platforms.Add(p3);
            v17.Platforms.Add(p4);
            v17.Genres.Add(g1);
            v17.Genres.Add(g13);

            v18.Platforms.Add(p3);
            v18.Platforms.Add(p4);
            v18.Genres.Add(g1);
            v18.Genres.Add(g13);

            context.VideoGames.AddOrUpdate(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
            context.SaveChanges();
            #endregion
            base.Seed(context);
        }
    }
}
