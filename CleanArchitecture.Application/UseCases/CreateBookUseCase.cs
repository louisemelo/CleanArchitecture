using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases
{
    public sealed class CreateBookUseCase : IUseCase<CreateBookInputModel>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public CreateBookUseCase(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this._bookRepository = bookRepository;
            this._authorRepository = authorRepository;
        }

        public async ValueTask ExecuteTaskAsync(CreateBookInputModel input)
        {

            var author = await _authorRepository.GetAuthorByName(input.AuthorName).ConfigureAwait(true);

            if (author == null)
            {
                author = new Author(input.AuthorName);

                _authorRepository.AddAuthor(author).ConfigureAwait(true);

                author = await _authorRepository.GetAuthorByName(input.AuthorName).ConfigureAwait(true);
            }

            var book = new Book(input.Name, author, input.Edition, input.Year);
        }
    }
}
