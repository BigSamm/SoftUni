namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using Dtos;
    using Messages;
    using Models.Enums;
    using Services.Contracts;

    public class ShareAlbumCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly IAlbumRoleService albumRoleService;

        public ShareAlbumCommand(IAlbumService albumService, IUserService userService, IAlbumRoleService albumRoleService)
        {
            this.albumService = albumService;
            this.userService = userService;
            this.albumRoleService = albumRoleService;
        }

        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public string Execute(string[] data)
        {
            int albumId = int.Parse(data[0]);
            string username = data[1];
            string permission = data[2];

            if (!this.albumService.Exists(albumId))
                throw new ArgumentException(String.Format(ErrorMessages.AlbumNotFound, albumId));

            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));

            bool isValidPermission = Enum.TryParse<Role>(permission, true, out Role parseResult);
            if (!isValidPermission)
                throw new ArgumentException(ErrorMessages.PermissionNotValid);

            int userId = this.userService.ByUsername<UserDto>(username).Id;
            this.albumRoleService.PublishAlbumRole(albumId, userId, permission);

            string albumName = this.albumService.ById<AlbumDto>(albumId).Name;
            string result = String.Format(ResultMessages.SuccessfullyAddedUserToAlbum, username, albumName, permission);
            return result;
        }
    }
}
