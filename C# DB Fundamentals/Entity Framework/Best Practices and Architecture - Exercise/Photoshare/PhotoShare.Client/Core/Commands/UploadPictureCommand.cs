namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Dtos;
    using Messages;
    using Contracts;
    using Services.Contracts;

    public class UploadPictureCommand : ICommand
    {
        private readonly IPictureService pictureService;
        private readonly IAlbumService albumService;

        public UploadPictureCommand(IPictureService pictureService, IAlbumService albumService)
        {
            this.pictureService = pictureService;
            this.albumService = albumService;
        }

        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public string Execute(string[] data)
        {
            string albumName = data[0];
            string pictureTitle = data[1];
            string path = data[2];
            
            if (!this.albumService.Exists(albumName))
                throw new ArgumentException(String.Format(ErrorMessages.AlbumNotFound, albumName));

            var albumId = this.albumService.ByName<AlbumDto>(albumName).Id;
            this.pictureService.Create(albumId, pictureTitle, path);

            string result = String.Format(ResultMessages.SuccessfullyAddedPictureToAlbum, pictureTitle, albumName);
            return result;
        }
    }
}
