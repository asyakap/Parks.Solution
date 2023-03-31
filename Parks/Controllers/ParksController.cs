using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksContext _db;

    public ParksController(ParksContext db)
    {
      _db = db;
    }

    [HttpGet("page/{page}")]
    public async Task<ActionResult<List<Park>>> GetParks(int page)
    {
      if (_db.Parks == null)
        return NotFound();

      var pageResults = 2f;
      var pageCount = Math.Ceiling(_db.Parks.Count() / pageResults);

      var parks = await _db.Parks
                      .Skip((page - 1) * (int)pageResults)
                      .Take((int)pageResults)
                      .ToListAsync();
      
      var response = new ParkResponse
      {
        Parks = parks,
        CurrentPage = page,
        Pages = (int)pageCount
      };

      return Ok(response);
    }

    [HttpGet]
    public async Task<List<Park>> Get(string name, string location, string description, string interestingFacts, string popularSights)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if(location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if(description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      if(interestingFacts != null)
      {
        query = query.Where(entry => entry.InterestingFacts == interestingFacts);
      }
      
      if(popularSights != null)
      {
        query = query.Where(entry => entry.PopularSights == popularSights);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
