namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Contracts;
    using Dtos;
    using Messages;
    using Models.Enums;
    using Utilities;
    using Services.Contracts;

    public class CreateAlbumCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly ITagService tagService;

        public CreateAlbumCommand(IAlbumService albumService, IUserService userService, ITagService tagService)
        {
            this.albumService = albumService;
            this.userService = userService;
            this.tagService = tagService;
        }

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            string username = data[0];
            string albumTitle = data[1];
            string bgColor = data[2];
            string[] tags = data.Skip(3).ToArray();

            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));

            if (this.albumService.Exists(albumTitle))
                throw new ArgumentException(String.Format(ErrorMessages.AlbumAlreadyExists, albumTitle));

            bool isColorExists = Enum.TryParse(bgColor, true, out Color color);
            if (!isColorExists)
                throw new ArgumentException(String.Format(ErrorMessages.ColorNotFound, bgColor));

            for (int index = 0; index < tags.Length; index++)
            {
                string tag = tags[index];
                tag = tag.ValidateOrTransform();

                if (!this.tagService.Exists(tag))
                    throw new ArgumentException(ErrorMessages.InvalidTags);
            }

            int userId = this.userService.ByUsername<UserDto>(username).Id;
            this.albumService.Create(userId, albumTitle, bgColor, tags);

            string result = String.Format(ResultMessages.SuccessfullyCreatedAlbum, albumTitle);
            return result;
        }
    }
}
