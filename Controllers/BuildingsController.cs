using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using buildingapi.Model;


namespace RocketElevatorsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class buildingsController : ControllerBase
    {
        private readonly MaximeAuger_mysqlContext _context;

        public buildingsController(MaximeAuger_mysqlContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Buildings>>> Getbuildings()
        {
            return await _context.Buildings.ToListAsync();
        }
        
        // Action that gives the list of buildings
        // GET: api/buildings/listofbuildings
        [HttpGet("listofbuildings")]
        public async Task<ActionResult<IEnumerable<Buildings>>> GetbuildingList()
        {
         
            
             var building = await (from cust in _context.Buildings
                            join bat in _context.Batteries on cust.Id equals bat.BuildingId
                            join col in _context.Columns on bat.Id equals col.BatteryId
                            join ele in _context.Elevators on col.Id equals ele.ColumnId
                            where ele.Status == "Intervention" || col.Status == "Intervention" || bat.Status == "Intervention"
                            select cust).Distinct().ToListAsync();
                  
            if (building == null)
            {
                return NotFound();
            }

            return building;
        }
    }

}









