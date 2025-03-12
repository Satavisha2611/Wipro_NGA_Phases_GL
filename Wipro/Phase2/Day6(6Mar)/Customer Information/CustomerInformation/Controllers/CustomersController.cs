using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerInformation.Models;

namespace CustomerInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly EFCoreDbContext _context;

        public CustomersController(EFCoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        ////Get: api/Menus
        //[HttpGet("/Menu")]
        //public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
        //{
        //    return await _context.Menus.ToListAsync();
        //}


        ////Get: api/Orders
        //[HttpGet("/Orders")]
        //public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        //{
        //    return await _context.Orders.ToListAsync();
        //}

        ////Get: api/Vendors
        //[HttpGet("/Vendors")]
        //public async Task<ActionResult<IEnumerable<Vendor>>> GetVendors()
        //{
        //    return await _context.Vendors.ToListAsync();
        //}

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
        //GET: api/Wallet/5
        [HttpGet("/searchByWalletId/{wid}")]
        public async Task<ActionResult<Wallet>> GetWallet(int wid)
        {
            Wallet wallet = await _context.Wallets.FindAsync(wid);

            if (wallet == null)
            {
                return NotFound();
            }

            return wallet;
        }

        ////GET: api/Wallet/5
        //[HttpGet("/searchByMenuId/{mid}")]
        //public async Task<ActionResult<Menu>> GetMenu(int mid)
        //{
        //    Menu menu = await _context.Menus.FindAsync(mid);

        //    if (menu == null)
        //    {
        //        return NotFound();
        //    }

        //    return menu;
        //}

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        [HttpGet("/login/{userName}/{password}")]
        public async Task<ActionResult<Customer>> Login(string userName, string password)
        {
            Customer? customer = _context.Customers.Where(x => x.CustUserName == userName && x.CustPassword == password).FirstOrDefault();
            if (customer == null)
            {
                return BadRequest("The information is not correct..") ;
            }
            return customer;

        }

        [HttpGet("/showWallet/{custId}")]
        public async Task<ActionResult<List<Wallet>>> ShowWallet(int custId)
        {
            var walletCustomer = await _context.Wallets.Where(x => x.CustId == custId ).ToListAsync();
            if (walletCustomer == null)
            {
                return NotFound("Wallet not found..");
            }
            return Ok(walletCustomer);

        }

        //Get: /searchCustomerWalletInfo/2
        [HttpGet("/searchCustomerWalletInfo/{custId}/{walletSource}")]
        public async Task<ActionResult<List<Wallet>>> SearchCustomerWalletInfo(int custId, string walletSource)
        {
            var walletCustomer = await _context.Wallets.Where(x => x.CustId == custId && x.WalletType == walletSource).ToListAsync();
            if (walletCustomer == null)
            {
                return NotFound("Wallet not found..");
            }
            return Ok(walletCustomer);

        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CustName) || string.IsNullOrWhiteSpace(customer.CustUserName) || string.IsNullOrWhiteSpace(customer.CustPassword))
            {
                return BadRequest("Name, Username and Password required...");
            }
            else
            {
                int custId = _context.Customers.Max(x => x.CustId);
                custId++;
                customer.CustId = custId;
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCustomer", new { id = customer.CustId }, customer);
            }
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustId == id);
        }
    }
}
