using System.Diagnostics;
using bil216proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace bil216proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(string name, string email, string subject, string message)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(message))
            {
                ViewBag.Mesaj = " Mesajınız başarıyla iletildi!";
            }
            else
            {
                ViewBag.Mesaj = " Lütfen tüm gerekli alanları doldurunuz.";
            }

            return View();
        }
        public static List<Kullanici> kullaniciListesi = new List<Kullanici>();
        public ActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayitOl(string fullname, string username, string email, string password)
        {
            if (!string.IsNullOrWhiteSpace(fullname) && !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(email))
            {
                Kullanici yeni = new Kullanici
                {
                    FullName = fullname,
                    UserName = username,
                    Email = email
                };

                kullaniciListesi.Add(yeni);

                ViewBag.Mesaj = "Kayıt başarılı!";
            }
            else
            {
                ViewBag.Mesaj = "Lütfen tüm alanları doldurun.";
            }

            return View();
        }

        public ActionResult List()
        {
            return View(kullaniciListesi);
        }
    }
}
