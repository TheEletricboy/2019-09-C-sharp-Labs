﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_50_api_todo_list_core;

namespace lab_50_api_todo_list_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private readonly TaskItemContext _context;

        public TaskItemsController(TaskItemContext context)
        {
            _context = context;
        }

        // GET: api/TaskItems
        [HttpGet]
        public List<TaskItem> GetTaskItems()
        {
            //var u = new User()
            //{
            //    UserName = "King" // ID = 1
            //};
            //_context.Add<User>(u);
            //_context.SaveChanges();
            //var t = new TaskItem()
            //{
            //    Description = "An Item",
            //    DateDue = DateTime.Parse("21/09/2019"),
            //    TaskDone = false,
            //    UserID = 1
            //};
            //_context.Add<TaskItem>(t);
            //_context.SaveChanges();
            //System.Diagnostics.Trace.WriteLine($"Added a record with ID {t.TaskItemID} and user {u.UserName}");
            return _context.TaskItems.ToList();
            //return _context.TaskItems;
        }

        // GET: api/TaskItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskItem = await _context.TaskItems.FindAsync(id);

            if (taskItem == null)
            {
                return NotFound();
            }

            return Ok(taskItem);
        }

        // PUT: api/TaskItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskItem([FromRoute] int id, [FromBody] TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskItem.TaskItemID)
            {
                return BadRequest();
            }

            _context.Entry(taskItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskItemExists(id))
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

        // POST: api/TaskItems
        [HttpPost]
        public async Task<IActionResult> PostTaskItem([FromBody] TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TaskItems.Add(taskItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskItem", new { id = taskItem.TaskItemID }, taskItem);
        }

        // DELETE: api/TaskItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taskItem = await _context.TaskItems.FindAsync(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            _context.TaskItems.Remove(taskItem);
            await _context.SaveChangesAsync();

            return Ok(taskItem);
        }

        private bool TaskItemExists(int id)
        {
            return _context.TaskItems.Any(e => e.TaskItemID == id);
        }
    }
}