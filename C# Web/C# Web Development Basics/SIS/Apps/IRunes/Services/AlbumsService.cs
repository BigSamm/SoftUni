namespace IRunes.Services
{
    using System;

    using Contracts;
    using Data;
    using Models;

    public class AlbumsService : IAlbumsService
    {
        private readonly IRunesDbContext dbContext;

        public AlbumsService(IRunesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool TryAddToDatabase(string name, string cover)
        {
            var album = new Album
            {
                Name = name,
                Cover = cover
            };

            this.dbContext.Albums.Add(album);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}