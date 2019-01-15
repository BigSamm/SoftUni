namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper.QueryableExtensions;

    using Data;
    using Models;
    using Contracts;

    public class TagService : ITagService
    {
        private readonly PhotoShareContext context;

        public TagService(PhotoShareContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
            => this.By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
            => this.By<TModel>(x => x.Name == name).SingleOrDefault();

        private IEnumerable<TModel> By<TModel>(Func<Tag, bool> predicate)
            => this.context.Tags
                   .Where(predicate)
                   .AsQueryable()
                   .ProjectTo<TModel>();

        public bool Exists(int id)
            => this.ById<Tag>(id) != null;

        public bool Exists(string name)
            => this.ByName<Tag>(name) != null;

        public Tag AddTag(string name)
        {
            Tag tag = new Tag
            {
                Name = name
            };

            this.context.Tags.Add(tag);
            this.context.SaveChanges();

            return tag;
        }
    }
}
