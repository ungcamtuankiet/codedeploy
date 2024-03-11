﻿using be_artwork_sharing_platform.Core.Dtos.Artwork;
using be_artwork_sharing_platform.Core.Dtos.General;
using be_artwork_sharing_platform.Core.Entities;
using System.Security.Claims;

namespace be_artwork_sharing_platform.Core.Interfaces
{
    public interface IArtworkService
    {
        Task<IEnumerable<ArtworkDto>> GetAll();
        Task<IEnumerable<Artwork>> SearchArtwork(string? search, string? searchBy, double? from, double? to, string? sortBy);
        Task<Artwork> GetById(long id);
        Task<IEnumerable<Artwork>> GetArtworkByUserId(string user_Id);
        Task CreateArtwork(CreateArtwork artworkDto, string user_Id, string user_Name);
        int Delete(long id);
        Task UpdateArtwork(long id, UpdateArtwork updateArtwork);
    }
}
