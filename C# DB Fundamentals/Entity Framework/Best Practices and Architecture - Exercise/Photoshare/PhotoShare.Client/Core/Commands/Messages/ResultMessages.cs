namespace PhotoShare.Client.Core.Commands.Messages
{
    public static class ResultMessages
    {
        public const string SuccessfullyRegisteredUser = "User {0} was registered successfully!";

        public const string SuccessfullyAddedTown = "Town {0} was added successfully!";

        public const string SuccessfullyModify = "User {0} {1} is {2}.";

        public const string SuccessfullyDeletedUser = "User {0} was deleted from the database!";

        public const string SuccessfullyAddedTag = "Tag {0} was added successfully!";

        public const string SuccessfullyCreatedAlbum = "Album {0} successfully created!";

        public const string SuccessfullyAddedTagToAlbum = "Tag {0} added to {1}!";

        public const string SuccessfullyAddedFriend = "Friend {0} added to {1}";

        public const string SuccessfullyAcceptedFriend = "{0} accepted {1} as a friend";

        public const string UserHaveNoFriends = "No friends for this user. :(";
        public const string Friends = "Friends:";
        public const string Friend = "-{0}";

        public const string SuccessfullyAddedUserToAlbum = "Username {0} added to album {1} ({2})";

        public const string SuccessfullyAddedPictureToAlbum = "Picture {0} added to {1}!";
    }
}
