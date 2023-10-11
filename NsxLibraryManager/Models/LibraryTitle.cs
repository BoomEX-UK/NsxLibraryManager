﻿using NsxLibraryManager.Enums;
using NsxLibraryManager.FileLoading.QuickFileInfoLoading;

namespace NsxLibraryManager.Models;

public record LibraryTitle
{

    public int Id { get; set; }
    public required string TitleId { get; init; }
 
    public string? ApplicationTitleId { get; set; }
    
    public string? ApplicationTitleName { get; set; }
    
    public string? PatchTitleId { get; set; }
    
    public int? PatchNumber { get; set; }
    public string? TitleName { get; set; }
    public string? Publisher { get; set; }
    public uint TitleVersion { get; init; }
    public uint AvailableVersion { get; set; }
    public TitleLibraryType Type { get; set; }
    public AccuratePackageType PackageType { get; init; }
    public required string FileName { get; set; }
    public string? NewFileName { get; set; }
    public bool Error { get; set; } = false;
    public string ErrorMessage { get; set; } = string.Empty;
};