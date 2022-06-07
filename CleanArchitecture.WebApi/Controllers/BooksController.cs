using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.Outputs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Books controller
    /// </summary>
    [ApiController]
    [Route("api")]
    public class BooksController : ControllerBase
    {
        private readonly IUseCaseCommand<CreateBookInput> _useCaseCreateBook;
        private readonly IUseCaseQuery<GetBookByNameInput> _useCaseGetBookByName;

        /// <summary>
        /// Bookds controller constructor
        /// </summary>
        /// <param name="useCaseCreateBook"></param>
        public BooksController(IUseCaseCommand<CreateBookInput> useCaseCreateBook, IUseCaseQuery<GetBookByNameInput> useCaseGetBookByName)
        {
            _useCaseCreateBook = useCaseCreateBook;
            _useCaseGetBookByName = useCaseGetBookByName;
        }

        /// <summary>
        /// Add book
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/books/add")]
        public async Task<IActionResult> AddBook(CreateBookInput request)
        {
            try
            {
                await _useCaseCreateBook.ExecuteTaskAsync(request).ConfigureAwait(true);

                return Ok(new CreatedBookOutput($"Author {request.Name} created successfully."));
            }
            catch (Exception ex)
            {
                var message = ((BaseException)ex).Messages;
                return BadRequest(new CreatedBookOutput(message, true));
            }
        }

        /// <summary>
        /// Get book by name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/books/getByName")]
        public async Task<IActionResult> GetBookByName([FromQuery] GetBookByNameInput request)
        {
            try
            {
                await _useCaseGetBookByName.ExecuteTaskAsync<GetBookByNameOutput>(request).ConfigureAwait(true);

                return Ok(new GetBookByNameOutput($"Book {request.Name} created successfully."));
            }
            catch (Exception ex)
            {
                var message = ((BaseException)ex).Messages;
                return BadRequest(new GetBookByNameOutput(message, true));
            }
        }
    }
}
