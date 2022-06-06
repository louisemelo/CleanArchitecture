using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Books controller
    /// </summary>
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        /// <summary>
        /// Books controller constructor
        /// </summary>
        /// <param name="bookService"></param>
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            try
            {
                var books = _bookService.GetAllBooks();

                if (books == null)
                {
                    return NotFound();
                }

                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get book by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/books/{id}")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                var book = _bookService.GetBookById(id);

                if (book == null)
                {
                    return NotFound();
                }

                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
