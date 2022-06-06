using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.UseCases;
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
        private readonly IUseCase<CreateBookInputModel> _useCaseCreateBook;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="useCaseCreateBook"></param>
        public BooksController(IUseCase<CreateBookInputModel> useCaseCreateBook)
        {
            _useCaseCreateBook = useCaseCreateBook;
        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddBook(CreateBookInputModel request)
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
