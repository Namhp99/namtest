using FireSharp.Response;
using LTNC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LTNC.Controllers
{
    public class QLSVController : Controller
    {
        ConnectFirebase connect = new ConnectFirebase();

        // GET: QLSV
        public ActionResult Index()
        {
            var client = connect.client;
            var res = client.Get("SinhVien/");
            var lst = new List<SinhVien>();
            return View(lst);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SinhVien sinhVien)
        {
            try
            {
                add(sinhVien);
                ModelState.AddModelError(string.Empty, "Ok");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            };
            return View();
        }

        private void add(SinhVien sinhVien)
        {
            var client = connect.client;
            var data = sinhVien;
            SetResponse setResponse = client.Set("SinhVien/", data);
        }
    }
}