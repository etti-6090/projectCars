using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Service;
using Microsoft.AspNetCore.Mvc;
using static CustomersController;

[Route("api/[controller]")]
[ApiController]
public class SellersController : ControllerBase
{
    private readonly ISellersService _sellersService;

    public SellersController(ISellersService sellersService)
    {
        _sellersService = sellersService;
    }



    [HttpGet]
    public IEnumerable<Seller> Get()
    {
        return _sellersService.GetList();

    }

    [HttpGet("{id}")]
    public ActionResult<Seller> GetById(string id)
    {
        var seller = _sellersService.GetList().Find(x => x.Id == id);
        if (seller != null)
        {
            return Ok(seller);
        }
        return NotFound();
    }

    [HttpPost]
    public Seller Post([FromBody] Seller value)
    {
        _context.Seller.Add(new Seller { Id = value.Id, YearsOfSeniority = value.YearsOfSeniority, IsActive = value.IsActive });
        return value;
    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Seller value)
    {
        

        var index = _context.Seller.FindIndex(e => e.Id == id);
        if (index >= 0)
        {
            _context.Seller[index].YearsOfSeniority = value.YearsOfSeniority;
            _context.Seller[index].IsActive = value.IsActive;
            return Ok(_context.Seller[index]);
        }
        return NotFound();
    }
}
