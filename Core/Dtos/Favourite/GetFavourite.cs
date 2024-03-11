﻿namespace be_artwork_sharing_platform.Core.Dtos.Favourite
{
    public class GetFavourite
    {
        public long Favourite_Id { get; set; }
        public long Artwork_Id { get; set; }
        public string Category_Name { get; set; }
        public string User_Name { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url_Image { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
