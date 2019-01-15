namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using Dtos;
    using Messages;
    using Services.Contracts;

    public class AddTagToCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly ITagService tagService;
        private readonly IAlbumTagService albumTagService;

        public AddTagToCommand(IAlbumService albumService, ITagService tagService, IAlbumTagService albumTagService)
        {
            this.albumService = albumService;
            this.tagService = tagService;
            this.albumTagService = albumTagService;
        }

        // AddTagTo <albumName> <tag>
        public string Execute(string[] data)
        {
            string albumName = data[0];
            string tag = data[1];

            bool isAlbumExist = this.albumService.Exists(albumName);
            bool isTagExist = this.tagService.Exists(tag);

            if (!isAlbumExist || !isTagExist)
                throw new ArgumentException(ErrorMessages.TagOrAlbumDoNotExist);

            int albumId = this.albumService.ByName<AlbumDto>(albumName).Id;
            int tagId = this.tagService.ByName<TagDto>(tag).Id;

            this.albumTagService.AddTagTo(albumId, tagId);

            string result = String.Format(ResultMessages.SuccessfullyAddedTagToAlbum, tag, albumName);
            return result;
        }
    }
}
