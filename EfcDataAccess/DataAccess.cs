using EfcDataAccess.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess;

public class DataAccess
{
    private readonly Context _context;

    public DataAccess(Context context)
    {
        _context = context;
    }

    public async Task<Show> CreateAsync(Show show)
    {
        EntityEntry<Show> newShow = await _context.Show.AddAsync(show);
        try
        {
            await _context.SaveChangesAsync();
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return newShow.Entity;
    }

    public async Task<Episode> addEpisodeToShow(Episode episode, string title)
    {
        Show show = _context.Show.FirstOrDefault(u => u.Title == title);
        show.Episodes.Add(episode);
        await _context.SaveChangesAsync();
        return episode;
    }

    public async Task<Episode> GetAllEpisodesFromShow(string? title)
    {
        Show show = _context.Show.FirstOrDefault(u => u.Title == title);
        return show.Episodes.FirstOrDefault();
    }
}