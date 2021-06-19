using Microsoft.AspNetCore.Mvc;
using Homework12.DAO;
using Homework12.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Homework12.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase {
        private readonly OrderService orderService;
        public OrderController(OrderService orderService) {
            this.orderService = orderService;
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id){
            return orderService.QueryByNumber(id);
        }
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order) {
            orderService.AddOrder(order);
            return order;
        }
       
    }

}



