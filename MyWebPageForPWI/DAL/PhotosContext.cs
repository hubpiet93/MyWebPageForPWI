using MyWebPageForPWI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyWebPageForPWI.DAL
{
    public class PhotosContext : DbContext
    {
        public PhotosContext() : base("PhotosDb")
        {

        }

        static PhotosContext()
        {
            Database.SetInitializer<PhotosContext>(new PhotosDbInitializer());
        }

        public static PhotosContext Create()
        {
            return new PhotosContext();
        }

        public DbSet<Zdjecie> Zdjecia { get; set; }     
    }
}