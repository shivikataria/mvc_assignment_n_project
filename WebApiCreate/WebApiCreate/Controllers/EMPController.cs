﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApiCreate.edm
{
    public class EMPController : ApiController
    {
        private companyEntities db = new companyEntities();

        // GET: api/EMP
        public IQueryable<employee> Getemployees()
        {
            return db.employees;
        }

        // GET: api/EMP/5
        [ResponseType(typeof(employee))]
        public async Task<IHttpActionResult> Getemployee(int id)
        {
            employee employee = await db.employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/EMP/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putemployee(int id, employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.employee_id)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EMP
        [ResponseType(typeof(employee))]
        public async Task<IHttpActionResult> Postemployee(employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employees.Add(employee);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = employee.employee_id }, employee);
        }

        // DELETE: api/EMP/5
        [ResponseType(typeof(employee))]
        public async Task<IHttpActionResult> Deleteemployee(int id)
        {
            employee employee = await db.employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.employees.Remove(employee);
            await db.SaveChangesAsync();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool employeeExists(int id)
        {
            return db.employees.Count(e => e.employee_id == id) > 0;
        }
    }
}