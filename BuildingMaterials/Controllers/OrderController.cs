﻿using DataAccess.Repository.IRepisitory;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;
using Utility.BrainTree;

namespace BuildingMaterials.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IBrainTreeGate _brain;

        public OrderController(
        IOrderHeaderRepository orderHRepo, IOrderDetailRepository orderDRepo, IBrainTreeGate brain)
        {
            _brain = brain;
            _orderDRepo = orderDRepo;
            _orderHRepo = orderHRepo;
        }


        public IActionResult Index(string searchName = null, string searchEmail = null, string searchPhone = null, string Status = null )
        {
            OrderListVM orderListVM = new OrderListVM()
            {
                OrderHList = _orderHRepo.GetAll(),
                StatusList = WC.listStatus.ToList().Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };

            if (!string.IsNullOrEmpty(searchName))
            {
                orderListVM.OrderHList = orderListVM.OrderHList.Where(u => u.FullName.ToLower().Contains(searchName.ToLower()));
            }
            if (!string.IsNullOrEmpty(searchEmail))
            {
                orderListVM.OrderHList = orderListVM.OrderHList.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower()));
            }
            if (!string.IsNullOrEmpty(searchPhone))
            {
                orderListVM.OrderHList = orderListVM.OrderHList.Where(u => u.PhoneNumber.ToLower().Contains(searchPhone.ToLower()));
            }
            if (!string.IsNullOrEmpty(Status) && Status != "--Order Status--")
            {
                orderListVM.OrderHList = orderListVM.OrderHList.Where(u => u.OrderStatus.ToLower().Contains(Status.ToLower()));
            }

            return View(orderListVM);
        }
    }
}
