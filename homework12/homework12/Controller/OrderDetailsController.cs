using Microsoft.AspNetCore.Mvc;
using Homework12.DAO;
using Homework12.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Homework12.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailController:ControllerBase {
        private readonly OrderContext orderDB;
        public OrderDetailController(OrderContext orderDB) {
            this.orderDB = orderDB;
        }
        [HttpPost]
        public ActionResult<bool> AddOrderDetails(List<OrderDetails> orderDetails)
        {
            if (orderDetails == null)
                return BadRequest();
            orderDB.orderDetails.AddRange(orderDetails);
            orderDB.SaveChanges();
            return true;
        }
        [HttpDelete]
        public ActionResult<OrderDetails> DeleteOrderDetail(OrderDetails orderDetail) {
            orderDB.orderDetails.Remove(orderDetail);
            orderDB.SaveChanges();
            return orderDetail; // 返回被删除的订单
        }
        [HttpPut]
        public ActionResult<bool> UpdateOrderDetail(OrderDetails orderDetail) {
            orderDB.Entry(orderDetail).State = EntityState.Modified;
            return true;
        }

    }
}