using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Service;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly  ICustomersService _customersService;
      

  public CustomersController(ICustomersService customersService)
    {
        _customersService = customersService;
    }


    [HttpGet]
    public ActionResult<Customer> Get()
    {
        return Ok(_customersService.GetList());
        
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> GetById(string id)
    {
        var customer = _customersService.GetList().Find(x => x.Id == id);
        if (customer != null)
        {
            return Ok(customer);
        }
        return NotFound();
    }

    [HttpPost]
    public Customer Post([FromBody] Customer value)
    {
        _context.Customer.Add(new Customer { Id = value.Id, PhoneNumber = value.PhoneNumber, IsActive = value.IsActive });
        return value;
    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Customer value)
    {
        var index = _context.Customer.FindIndex(e => e.Id == id);
        if (index >= 0)
        {
            _context.Customer[index].PhoneNumber = value.PhoneNumber;
            _context.Customer[index].IsActive = value.IsActive;
            return Ok(_context.Customer[index]);
        }
        return NotFound();
    }
}
