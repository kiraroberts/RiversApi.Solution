﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiversAPI.Models;

namespace RiversAPI.Migrations
{
    [DbContext(typeof(RiversAPIContext))]
    partial class RiversAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RiversAPI.Models.River", b =>
                {
                    b.Property<int>("RiverId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Flow");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Length");

                    b.Property<string>("Mouth");

                    b.Property<string>("Name");

                    b.Property<string>("Source");

                    b.Property<string>("States");

                    b.Property<string>("Tributaries");

                    b.HasKey("RiverId");

                    b.ToTable("Rivers");

                    b.HasData(
                        new
                        {
                            RiverId = 1,
                            Flow = "265,000 cu ft/s ",
                            ImageURL = "https://www.worldatlas.com/r/w728-h425-c728x425/upload/b0/40/ea/shutterstock-275634467.jpg",
                            Length = "1,243 miles",
                            Mouth = "Pacific Ocean",
                            Name = "Columbia River",
                            Source = "Columbia Lake",
                            States = "Washington, Oregon, British Columbia",
                            Tributaries = "Spillimacheen River, Beaver River, Illecillewaet River, Incomappleux River, Kootenay River, Pend Oreille River, Spokane River, Crab Creek, Snake River, John Day River, Deschutes River, Willamette River, Kicking Horse River, Blaeberry River, Canoe River, Kettle River, Sanpoil River, Okanogan River, Entiat River, Wenatchee River, Yakima River, Lewis River, Cowlitz River"
                        },
                        new
                        {
                            RiverId = 2,
                            Flow = "33,010 cu ft/s",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/4/4d/USACE_Fremont_Bridge_Portland.jpg",
                            Length = "187 miles",
                            Mouth = "Columbia River",
                            Name = "Willamette River",
                            Source = "Coast Fork Willamette River and Middle Fork Willamette River",
                            States = "Oregon",
                            Tributaries = "Coast Fork Willamette River, Long Tom River, Marys River, Luckiamute River, Yamhill River, Tualatin River, Middle Fork Willamette River, McKenzie River, Calapooia River, Santiam River, Molalla River, Clackamas River"
                        },
                        new
                        {
                            RiverId = 3,
                            Flow = "5,824 cu ft/s",
                            ImageURL = "https://media-cdn.tripadvisor.com/media/photo-s/0e/9d/b8/0e/the-lower-deschutes-river.jpg",
                            Length = "252 miles",
                            Mouth = "Columbia River",
                            Name = "Deschutes River",
                            Source = "Little Lava Lake",
                            States = "Oregon",
                            Tributaries = "Cultus River, Fall River, Little Deschutes River, Spring River, Metolius River, Crooked River, Warm Springs River, White River"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
