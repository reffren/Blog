using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Wexplorer.Data.Entities;

namespace Wexplorer.Data.Configuration
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(p => p.PostID);
            Property(p => p.Title).HasMaxLength(100);
            Property(p => p.Description).HasMaxLength(160);
            Property(p => p.PublishedDate).HasColumnType("datetime2");
            Property(p => p.LastModifiedDate).HasColumnType("datetime2");
            Property(p => p.UrlPost).HasMaxLength(100);
            Property(p => p.Picture).HasMaxLength(100);
        }
    }
}