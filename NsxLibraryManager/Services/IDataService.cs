﻿using NsxLibraryManager.Models;
using NsxLibraryManager.Repository;

namespace NsxLibraryManager.Services;

public interface IDataService : IDisposable
{
    public Task Import();
    new void Dispose();
  
    public ITitleRepository TitleRepository { get; }
    public IRegionRepository RegionRepository(string region);
    
    public Task<IEnumerable<RegionTitle>> GetRegionTitlesAsync(string region);
    
    public Task AddLibraryTitleAsync(LibraryTitle libraryTitle);
    public DateTime? GetRegionLastUpdate(string region, CancellationToken cancellationToken = default);
}