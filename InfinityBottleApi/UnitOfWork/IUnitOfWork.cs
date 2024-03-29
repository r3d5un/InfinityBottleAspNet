﻿using InfinityBottleApi.Repository.Interfaces;

namespace InfinityBottleApi.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IBrandRepository Brands { get; }
    ICategoryRepository Categories { get; }
    ICountryRepository Countries { get; }
    ICompanyRepository Companies { get; }
    IHistoryRepository Histories { get; }
    IInfinityBottleRepository InfinityBottles { get; }
    IWhiskyRepository Whiskies { get; }

    int Complete();
    Task<int> CompleteAsync();
}
