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
                    new River { RiverId = 1, Name = "Columbia River", Length = "1,243 miles", Source = "Columbia Lake", Mouth = "Pacific Ocean", Flow = "265,000 cu ft/s ", States = "Washington, Oregon, British Columbia", Tributaries = "Spillimacheen River, Beaver River, Illecillewaet River, Incomappleux River, Kootenay River, Pend Oreille River, Spokane River, Crab Creek, Snake River, John Day River, Deschutes River, Willamette River, Kicking Horse River, Blaeberry River, Canoe River, Kettle River, Sanpoil River, Okanogan River, Entiat River, Wenatchee River, Yakima River, Lewis River, Cowlitz River" },

                    new River {RiverId = 2, Name = "Willamette River", Length = "187 miles", Source = "Coast Fork Willamette River and Middle Fork Willamette River", Mouth = "Columbia River", Flow = "33,010 cu ft/s", States = "Oregon", Tributaries = "Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River" },


                    new River { RiverId = 3, Name = "Deschutes River", Length = "252 miles", Source = "Little Lava Lake", Mouth = "Columbia River", Flow = "5,824 cu ft/s", States = "Oregon", Tributaries = "Cultus River, Fall River, Little Deschutes River, Spring River, Metolius River, Crooked River, Warm Springs River, White River" }
                ); 




        }      
            
    }
}