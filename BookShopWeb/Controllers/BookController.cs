using BookShopWeb.Data;
using BookShopWeb.Models;
using BookShopWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BookController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(string? CName)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;

            if (CName != null)
            {
                IEnumerable<Book> categoryBooks = _context.Books.Where(x => x.Category.Name == CName).Include(b => b.Category);
                return View(categoryBooks);
            }
            IEnumerable<Book> books = _context.Books.Include(x => x.Category).ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel book)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;

            if (ModelState.IsValid)
            {
                if (book.Title.ToLower() == book.Author.ToLower())
                {
                    ModelState.AddModelError("Title", "Title can not be same as Author Name");
                    return View(book);
                }
                var exist = _context.Books.FirstOrDefault(x => x.Title.ToLower() == book.Title.ToLower());
                if (exist != null)
                {
                    ModelState.AddModelError("Title", "This book already exist.");
                    return View(book);
                }
                Book mainBook = new Book()
                {
                    Title = book.Title,
                    Author = book.Author,
                    Publisher = book.Publisher,
                    PublishDate = book.PublishDate,
                    Quantity = book.Quantity,
                    CoverPicture = "CoverPicture\\default.jpg",
                    CategoryId = book.CategoryId
                };
                if (book.CoverPicture != null)
                {
                    string rootPath = _env.WebRootPath;
                    string picPath = "CoverPicture\\" + Guid.NewGuid().ToString() + book.CoverPicture.FileName.ToString();
                    string fullPath = Path.Combine(rootPath, picPath);
                    FileStream stream = new FileStream(fullPath, FileMode.Create);
                    book.CoverPicture.CopyTo(stream);
                    stream.Close();
                    mainBook.CoverPicture = picPath;
                }
                _context.Books.Add(mainBook);
                _context.SaveChanges();
                TempData["success"] = "Successfuly created.!";
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;
            Book book = _context.Books.Find(Id);
            ViewBag.CoverPicture = book.CoverPicture;

            BookViewModel bookViewModel = new BookViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Publisher = book.Publisher,
                PublishDate = book.PublishDate,
                Quantity = book.Quantity,
                CategoryId = book.CategoryId
            };
            return View(bookViewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookViewModel book)
        {

            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;
            if (ModelState.IsValid)
            {
                if (book.Title.ToLower() == book.Author.ToLower())
                {
                    ModelState.AddModelError("Title", "Title can not be same as Author Name");
                    return View(book);
                }
                Book mainBook = _context.Books.Find(book.Id);
                mainBook.Title = book.Title;
                mainBook.Author = book.Author;
                mainBook.Publisher = book.Publisher;
                mainBook.PublishDate = book.PublishDate;
                mainBook.Quantity = book.Quantity;
                mainBook.CategoryId = book.CategoryId;
                if (book.CoverPicture != null)
                {
                    string rootPath = _env.WebRootPath;
                    string picPath = "CoverPicture\\" + Guid.NewGuid().ToString() + book.CoverPicture.FileName.ToString();
                    string fullPath = Path.Combine(rootPath, picPath);
                    FileStream stream = new FileStream(fullPath, FileMode.Create);
                    book.CoverPicture.CopyTo(stream);
                    stream.Close();
                    mainBook.CoverPicture = picPath;
                }
                _context.Books.Update(mainBook);
                _context.SaveChanges();
                TempData["success"] = "Successfuly edited.!";
                return RedirectToAction("Index");
            }
            return View(book);
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Category = categories;
            Book book = _context.Books.Find(Id);
            ViewBag.CoverPicture = book.CoverPicture;
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
            TempData["success"] = "Successfuly deleted.!";
            return RedirectToAction("Index");
        }
    }
}
