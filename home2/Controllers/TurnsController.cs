using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Serivce;
using home2.Service;
using Microsoft.AspNetCore.Mvc;
using static SellersController;

[Route("api/[controller]")]
[ApiController]
public class TurnsController : ControllerBase
{
    private readonly ITurnsService _turnsService;

    public TurnsController(ITurnsService turnsService)
    {
        _turnsService = turnsService;
    }
  

    [HttpGet]
    public IEnumerable<Turn> Get()
    {
        return _turnsService.GetList();

    }
    [HttpGet("{id}")]
    public ActionResult<Turn> GetById(string id)
    {
        var turn = _turnsService.GetList().Find(x => x.Id == id);
        if (turn != null)
        {
            return Ok(turn);
        }
        return NotFound();
    }

    [HttpPost]
    public Turn Post([FromBody] Turn value)
    {
        _context.Turn.Add(new Turn { Id = value.Id, Day = value.Day, Hour = value.Hour });
        return value;
    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Turn value)
    {
        var turn = _context.Turn.Find(x => x.Id == id);
        if (turn != null)
        {
            turn.Day = value.Day;
            turn.Hour = value.Hour;
            return Ok(turn);
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var index = _context.Turn.FindIndex(e => e.Id == id);
        if (index >= 0)
        {
            _context.Turn.RemoveAt(index);
            return NoContent();
        }
        return NotFound();
    }
}
