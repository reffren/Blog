using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Wexplorer.Data.Entities;

namespace Wexplorer.Data.Configuration
{
    public class CommentConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentConfiguration()
        {
            HasKey(p => p.CommentID);
            Property(p => p.NameUser).HasMaxLength(50);
            Property(p => p.Email).HasMaxLength(80);
            Property(p => p.Site).HasMaxLength(100);
            Property(p=>p.PublishedDate).HasColumnType("datetime2");

        }
    }
}