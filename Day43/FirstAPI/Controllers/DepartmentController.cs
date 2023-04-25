using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        static List<string> departmentNames = new List<string>() { "Ops", "Admin", "HR" };

        [ProducesResponseType(typeof(List<string>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<List<string>> Get()
        {
            if (departmentNames.Count == 0)
                return NotFound("NO data for department");
            return Ok(departmentNames);
        }
       
        //[HttpGet]
        //[ActionName("GetById")]
        [HttpGet("GetById")]
        public ActionResult<string> Get(int idx)
        {
            if(idx<0 || idx > departmentNames.Count)
                return NotFound();
            return Ok(departmentNames[idx]);
        }
        [HttpPut]
        public ActionResult<string> Edit(string oldname,string name)
        {
            int idx = departmentNames.IndexOf(oldname);
            if (idx != -1)
            {
                departmentNames[idx] = name;
                return Ok(name);
            }
            return NotFound("Unable to edit");
        }
        [HttpPost]
        public ActionResult<string> Post(string name)
        {
            if (departmentNames.Contains(name))
                return BadRequest("Duplicate department");
            departmentNames.Add(name);
            return Created("Department Names",name);
        }
       
        [HttpDelete]
        public ActionResult<string> Delete(string name)
        {
            if (departmentNames.Contains(name))
            {
                departmentNames.Remove(name);
                return Ok(name);
            }
            return BadRequest("Deparmnet not presnet");
        }
        
    }
}
