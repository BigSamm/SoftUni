namespace PhotoShare.Client.Core.Commands.Messages
{
    public static class ErrorMessages
    {
        public const string InvalidData = "Invalid data!";
        public const string PasswordsDoNotMatch = "Passwords do not match!";
        public const string UsernameIsTaken = "Username {0} is already taken!";

        public const string TownAlreadyAdded = "Town {0} was already added!";

        public const string ValueNotValid = "Value {0} not valid.";
        public const string InvalidPassword = "Invalid Password!";
        public const string TownNotFound = "Town {0} not found!";
        public const string PropertyNotSupported = "Property {0} not supported!";

        public const string UserNotFound = "User {0} not found!";

        public const string TagAlreadyExists = "Tag {0} exists!";

        public const string AlbumAlreadyExists = "Album {0} exists!";
        public const string ColorNotFound = "Color {0} not found!";
        public const string InvalidTags = "Invalid tags!";

        public const string TagOrAlbumDoNotExist = "Either tag or album do not exist!";

        public const string AlreadyFriends = "{0} is already a friend to {1}";
        public const string RequestAlreadySend = "Request is already send!";
        public const string NoFriendRequest = "{0} has not added {1} as a friend";

        public const string AlbumNotFound = "Album {0} not found!";
        public const string PermissionNotValid = "Permission must be either “Owner” or “Viewer”!";
    }
}
