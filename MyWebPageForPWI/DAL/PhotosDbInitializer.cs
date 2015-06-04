using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyWebPageForPWI.Migrations;

namespace MyWebPageForPWI.DAL
{
    public class PhotosDbInitializer : MigrateDatabaseToLatestVersion<PhotosContext,Configuration>
    {
        public static void SeedPhotos(PhotosContext context)
        {
            
        }
    }
}