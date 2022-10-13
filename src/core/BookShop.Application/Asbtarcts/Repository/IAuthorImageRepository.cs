﻿using BookShop.Application.Asbtarcts.Common;
using BookShop.Application.Asbtarcts.Repository.Base;
using BookShop.Domain.Entities;

namespace BookShop.Application.Asbtarcts.Repository;

public interface IAuthorImageRepository : IRepository<IApplicationDbContext, AuthorImage, string>
{
}
