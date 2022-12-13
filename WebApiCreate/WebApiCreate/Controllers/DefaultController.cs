using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApiCreate.edm;

namespace WebApiCreate.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            List<employee> li = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.GetAsync("api/EMP");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<List<employee>>();
                }
            }

            return View(li);
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(employee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.PostAsJsonAsync($"api/EMP", obj);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error..!");
            return View();
        }
        public async Task<ActionResult> Edit(int id)
        {
            employee li = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.GetAsync($"api/EMP/{id}");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<employee>();
                }
            }

            return View(li);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(employee obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.PostAsJsonAsync($"api/EMP/{obj.employee_id}", obj);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error..!");
            return View();
        }

        public async Task<ActionResult> Delete(int id)
        {
            employee li = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.GetAsync($"api/EMP/{id}");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<employee>();
                }
            }

            return View(li);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<ActionResult> DeleteRec(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.DeleteAsync($"api/EMP/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Error..!");
            return View();
        }

    }
}