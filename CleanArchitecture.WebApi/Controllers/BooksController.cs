using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Inputs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Books controller
    /// </summary>
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IUseCase<CreateBookInput> _useCaseCreateBook;

        /// <summary>
        /// Bookds controller constructor
        /// </summary>
        /// <param name="useCaseCreateBook"></param>
        public BooksController(IUseCase<CreateBookInput> useCaseCreateBook)
        {
            _useCaseCreateBook = useCaseCreateBook;
        }

        /// <summary>
        /// Add book
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> AddBook(CreateBookInput request)
        {
            try
            {
                await _useCaseCreateBook.ExecuteTaskAsync(request).ConfigureAwait(true);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
