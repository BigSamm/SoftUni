namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using Messages;
    using Services.Contracts;
    using Utilities;

    public class AddTagCommand : ICommand
    {
        private readonly ITagService tagService;

        public AddTagCommand(ITagService tagService)
        {
            this.tagService = tagService;
        }

        // AddTag <tag>
        public string Execute(string[] args)
        {
            string tagName = args[0];

            if (this.tagService.Exists(tagName))
                throw new ArgumentException(String.Format(ErrorMessages.TagAlreadyExists, tagName));

            tagName = tagName.ValidateOrTransform();
            this.tagService.AddTag(tagName);

            string result = String.Format(ResultMessages.SuccessfullyAddedTag, tagName);
            return result;
        }
    }
}
