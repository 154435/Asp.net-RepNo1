﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using LMS.web.Data;
using LMS.web.Models;

namespace LMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        // POST: api/Books
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.BookId }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return book;
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}


















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using LMS.web.Data;
//using LMS.web.Models;

//namespace LMS.web.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BooksController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public BooksController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Books
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
//        {
//            return await _context.Books.ToListAsync();
//        }

//        // GET: api/Books/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Book>> GetBook(int id)
//        {
//            var book = await _context.Books.FindAsync(id);

//            if (book == null)
//            {
//                return NotFound();
//            }

//            return book;
//        }

//        // PUT: api/Books/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutBook(int id, Book book)
//        {
//            if (id != book.BookId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(book).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!BookExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Books
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<Book>> PostBook(Book book)
//        {
//            _context.Books.Add(book);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetBook", new { id = book.BookId }, book);
//        }

//        // DELETE: api/Books/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Book>> DeleteBook(int id)
//        {
//            var book = await _context.Books.FindAsync(id);
//            if (book == null)
//            {
//                return NotFound();
//            }

//            _context.Books.Remove(book);
//            await _context.SaveChangesAsync();

//            return book;
//        }

//        private bool BookExists(int id)
//        {
//            return _context.Books.Any(e => e.BookId == id);
//        }
//    }
//}
