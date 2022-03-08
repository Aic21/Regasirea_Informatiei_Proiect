using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        public Task DeleteById(int id);
        public Task Delete(Order order);
        public Task<Order> GetById(string id);
    }
}
