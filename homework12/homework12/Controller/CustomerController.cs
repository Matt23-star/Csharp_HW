using Microsoft.AspNetCore.Mvc;
using Homework12.DAO;
using Homework12.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Homework12.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController:ControllerBase
    {
        private readonly OrderContext orderDB;
        public CustomerController(OrderContext orderDB) {
            this.orderDB = orderDB;
        }
        [HttpPost("{orderID}")]
        public ActionResult<bool> AddCustomer(Client client,long orderID) {
            if(client == null)
              return BadRequest();
            var order =  orderDB.orders.Where(o => o.OrderNumber == orderID).Include(o => o.Client).FirstOrDefault();
            order.Client = client;
            orderDB.Entry(order).State = EntityState.Modified;
            return true;
        }
    }
}
