using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkOrdersController
    {
        private ILogger<WorkOrdersController> _logger;
        private IWorkOrdersService _service;

        public WorkOrdersController(ILogger<WorkOrdersController> logger, IWorkOrdersService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("/WorkOrders")]
        public async Task<List<WorkOrder>> GetWorkOrdersAsync()
        {
            return await _service.GetWorkOrdersAsync();
        }

        [HttpGet]
        [Route("/WorkOrders/{id}")]
        public async Task<WorkOrder> GetWorkOrderById(int id)
        {
            return await _service.GetWorkOrderByIdAsync(id);
        }

        [HttpPost]
        [Route("/WorkOrders")]
        public async Task<WorkOrder> AddNewWorkOrder([FromBody] NewWorkOrderRequest WorkOrderRequest)
        {
            return await _service.AddNewWorkOrderAsync(WorkOrderRequest.NewJob);
        }

        [HttpPut]
        [Route("/WorkOrders")]
        public async Task<WorkOrder> UpdateExistingWorkOrder([FromBody] ExistingWorkOrderRequest WorkOrderRequest)
        {
            return await _service.UpdateExistingWorkOrderAsync(WorkOrderRequest.WorkOrderToUpdate);
        }
    }
}