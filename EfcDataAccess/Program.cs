// See https://aka.ms/new-console-template for more information

using EfcDataAccess;
using EfcDataAccess.Entities;


using var db = new Context();

Show show = new Show();
show.Title = "The Office";
show.Year = 2005;
show.Genre = "Comedy";

Show show2 = new Show();
show2.Title = "Friends";
show2.Year = 2005;
show2.Genre = "Comedy";

Episode episode = new Episode();
episode.Title = "The Dundies";
episode.Runtime = 30;
episode.SeasonId = "S01";
episode.ShowTitle = "The Office";

Episode episode2 = new Episode();
episode2.Title = "The Alliance";
episode2.Runtime = 30;
episode2.SeasonId = "S01";
episode2.ShowTitle = "The Office";

Episode episode3 = new Episode();
episode3.Title = "The One Where Monica Gets a Roommate";
episode3.Runtime = 30;
episode3.SeasonId = "S01";
episode3.ShowTitle = "Friends";

Episode episode4 = new Episode();
episode4.Title = "The One with the Sonogram at the End";
episode4.Runtime = 30;
episode4.SeasonId = "S01";
episode4.ShowTitle = "Friends";

await db.Show.AddAsync(show);
await db.Show.AddAsync(show2);
await db.Episode.AddAsync(episode);
await db.Episode.AddAsync(episode2);
await db.Episode.AddAsync(episode3);
await db.Episode.AddAsync(episode4);

