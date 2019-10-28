using Microsoft.EntityFrameworkCore;

namespace RiversAPI.Models
{
    public class RiversAPIContext : DbContext
    {
        public RiversAPIContext(DbContextOptions<RiversAPIContext> options)
            : base(options)
        {
        }

        public DbSet<River> Rivers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<River>()
                .HasData(
                    new River { RiverId = 1, Name = "Columbia River", Length = "1,243 miles", Source = "Columbia Lake", Mouth = "Pacific Ocean", Flow = "265,000 cu ft/s ", Counties = "Clatsop, Columbia, Multnomah, Hood River, Wasco, Sherman, Gilliam, Morrow, Umatilla", Tributaries = "Spillimacheen River, Beaver River, Illecillewaet River, Incomappleux River, Kootenay River, Pend Oreille River, Spokane River, Crab Creek, Snake River, John Day River, Deschutes River, Willamette River, Kicking Horse River, Blaeberry River, Canoe River, Kettle River, Sanpoil River, Okanogan River, Entiat River, Wenatchee River, Yakima River, Lewis River, Cowlitz River", ImageURL = "https://www.worldatlas.com/r/w728-h425-c728x425/upload/b0/40/ea/shutterstock-275634467.jpg"},

                    new River {RiverId = 2, Name = "Willamette River", Length = "187 miles", Source = "Coast Fork Willamette River and Middle Fork Willamette River", Mouth = "Columbia River", Flow = "33,010 cu ft/s", Counties = "Lane, Linn, Benton, Marion, Yamhill, Clackamas, Multnomah, Washington", Tributaries = "Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/4/4d/USACE_Fremont_Bridge_Portland.jpg"},


                    new River { RiverId = 3, Name = "Deschutes River", Length = "252 miles", Source = "Little Lava Lake", Mouth = "Columbia River", Flow = "5,824 cu ft/s", Counties = "Deschutes, Jefferson, Sherman, Wasco", Tributaries = "Cultus River, Fall River, Little Deschutes River, Spring River, Metolius River, Crooked River, Warm Springs River, White River", ImageURL = "https://media-cdn.tripadvisor.com/media/photo-s/0e/9d/b8/0e/the-lower-deschutes-river.jpg"},

                    new River { RiverId = 4, Name = "Alsea River", Length = "48.5 miles", Source = "North and South Fork Alsea River", Mouth = "Pacific Ocean", Flow = "1,459 cu ft/s", Counties = "Benton, Lincoln, Lane", Tributaries = "Lobster Creek, Fall Creek, Five Rivers System, Drift Creek", ImageURL = "https://i.ytimg.com/vi/waTf3KbZAHw/maxresdefault.jpg" },

                     new River { RiverId = 5, Name = "McKenzie River", Length = "90 miles", Source = "Clear Lake", Mouth = "Willamette River", Flow = "5,905 cu ft/s", Counties = "Lane, Linn", Tributaries = "Mohawk River, Blue River, Gate Creek, Quartz Creek, Horse Creek, Lost Creek", ImageURL = "https://thatoregonlife.com/wp-content/uploads/2016/07/mckenzieriver.jpg" },

                     new River { RiverId = 5, Name = "Nestucca River", Length = "57 miles", Source = "Central Oregon Coast Range", Mouth = "Nestucca Bay", Flow = "1,050 cu ft/s", Counties = "Tillamook", Tributaries = " ", ImageURL = "https://cdn.recreation.gov/public/images/78732.JPG" }

                ); 




        }      
            
    }
}