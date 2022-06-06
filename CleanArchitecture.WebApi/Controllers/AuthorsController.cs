using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Authors controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUseCase<CreateAuthorInput> _useCaseCreateAuthor;

        /// <summary>
        /// Authors controller constructor
        /// </summary>
        /// <param name="useCaseCreateAuthor"></param>
        public AuthorsController(IUseCase<CreateAuthorInput> useCaseCreateAuthor)
        {
            _useCaseCreateAuthor = useCaseCreateAuthor;
        }

        /// <summary>
        /// Add author
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> AddBook(CreateAuthorInput request)
        {
            try
            {
                await _useCaseCreateAuthor.ExecuteTaskAsync(request).ConfigureAwait(true);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
