using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;
using HomeBuilders.Api.Requests;
using api.business.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    /// <summary>
    /// Handles management of WorkOrder resources
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WorkOrdersController
    {
        private ILogger<WorkOrdersController> _logger;
        private IWorkOrdersService _service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Instance of Logger service</param>
        /// <param name="service">Instance of WorkOrder service</param>
        public WorkOrdersController(ILogger<WorkOrdersController> logger, IWorkOrdersService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets a list of all WorkOrder resources.
        /// </summary>
        /// <param name="pageItemCount">Indicates how many items to return per page</param>
        /// <returns>A list of WorkOrders</returns>
        [HttpGet]
        [Route("/WorkOrders")]
        public async Task<IEnumerable<WorkOrder>> GetWorkOrdersAsync(int pageItemCount = 15)
        {
            return await _service.GetWorkOrdersAsync();
        }

        /// <summary>
        /// Gets a single instance of WorkOrder
        /// </summary>
        /// <param name="id">Unique identifier for a WorkOrder</param>
        /// <returns>A WorkOrder instance</returns>
        [HttpGet]
        [Route("/WorkOrders/{id}")]
        public async Task<WorkOrder> GetWorkOrderById(int id)
        {
            return await _service.GetWorkOrderByIdAsync(id);
        }

        /// <summary>
        /// Adds a new WorkOrder resource to the permanent record
        /// </summary>
        /// <param name="WorkOrderRequest">Well-formed info for the WorkOrder to be added</param>
        /// <returns>The WorkOrder resource that was added to the platform</returns>
        [HttpPost]
        [Route("/WorkOrders")]
        public async Task<WorkOrder> AddNewWorkOrder([FromBody] NewWorkOrderRequest WorkOrderRequest)
        {
            return await _service.AddNewWorkOrderAsync(WorkOrderRequest.NewJob);
        }

        /// <summary>
        /// Updates an existing WorkOrder resource
        /// </summary>
        /// <param name="WorkOrderRequest">Well-formed info for the WorkOrder to be updated</param>
        /// <returns>The WorkOrder resource that was updated on the platform</returns>
        [HttpPut]
        [Route("/WorkOrders")]
        public async Task<WorkOrder> UpdateExistingWorkOrder([FromBody] ExistingWorkOrderRequest WorkOrderRequest)
        {
            return await _service.UpdateExistingWorkOrderAsync(WorkOrderRequest.WorkOrderToUpdate);
        }
    }
}