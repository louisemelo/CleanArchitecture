using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Inputs;
using CleanArchitecture.Application.Outputs;
using CleanArchitecture.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Authors controller
    /// </summary>
    [Route("api")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUseCaseCommand<CreateAuthorInput> _useCaseCreateAuthor;
        private readonly IUseCaseQuery<GetAuthorByNameInput> _useCaseQueryGetAuthorByName;


        /// <summary>
        /// Authors controller constructor
        /// </summary>
        /// <param name="useCaseCreateAuthor"></param>
        public AuthorsController(IUseCaseCommand<CreateAuthorInput> useCaseCreateAuthor,
                                 IUseCaseQuery<GetAuthorByNameInput> useCaseQueryGetAuthorByName)
        {
            _useCaseCreateAuthor = useCaseCreateAuthor;
            _useCaseQueryGetAuthorByName = useCaseQueryGetAuthorByName;
        }

        /// <summary>
        /// Add author
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/authors/add")]
        public async Task<IActionResult> AddAuthor(CreateAuthorInput request)
        {
            try
            {
                await _useCaseCreateAuthor.ExecuteTaskAsync(request).ConfigureAwait(true);

                return Ok(new CreatedAuthorOutput($"Author {request.Name} created successfully."));
            }
            catch (Exception ex)
            {
                var message = ((BaseException)ex).Messages;
                return BadRequest(new CreatedAuthorOutput(message, true));
            }
        }

        /// <summary>
        /// Get author by name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/authors/getByName")]
        public async Task<IActionResult> GetAuthorByName([FromQuery] GetAuthorByNameInput request)
        {
            try
            {
                var result = await _useCaseQueryGetAuthorByName.ExecuteTaskAsync(request).ConfigureAwait(true);

                return Ok(result._result as GetAuthorByNameOutput);
            }
            catch (Exception ex)
            {
                var message = ((BaseException)ex).Messages;
                return BadRequest(new GetAuthorByNameOutput(message, true));
            }
        }
    }
}
