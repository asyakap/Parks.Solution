﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

#nullable disable

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    [Migration("20230331164036_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Parks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("InterestingFacts")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PopularSights")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "Mount Rainier National Park, a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier.",
                            InterestingFacts = "Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams.",
                            Location = " Washington state",
                            Name = "Mount Rainier National Park",
                            PopularSights = "Paradise, Longmire, Sunrise."
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "Yosemite National Park is in California’s Sierra Nevada mountains. It’s famed for its giant, ancient sequoia trees, and for Tunnel View, the iconic vista of towering Bridalveil Fall and the granite cliffs of El Capitan and Half Dome.",
                            InterestingFacts = "Of California's 7,000 plant species, approximately 50 percent occur in the Sierra Nevada and more than 20 percent are within Yosemite.",
                            Location = " California state",
                            Name = "Yosemite National Park",
                            PopularSights = "El Capitan, Half Dome, The Tunnel View."
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "Joshua Tree National Park is a vast protected area in southern California. It's characterized by rugged rock formations and stark desert landscapes. Named for the region’s twisted, bristled Joshua trees, the park straddles the cactus-dotted Colorado Desert and the Mojave Desert, which is higher and cooler.",
                            InterestingFacts = "Joshua Tree is a popular observing site in Southern California for amateur astronomy and stargazing.",
                            Location = "Southern California",
                            Name = "Joshua Tree National Park",
                            PopularSights = "Giant Marbles, Hidden Valley, Cholla Cactus Garden."
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Grand Canyon National Park, in Arizona, is home to much of the immense Grand Canyon, with its layered bands of red rock revealing millions of years of geological history.",
                            InterestingFacts = "The canyon was created by the incision of the Colorado River and its tributaries after the Colorado Plateau was uplifted, causing the Colorado River system to develop along its present path",
                            Location = "Arizona State",
                            Name = "Grand Canyon National Park",
                            PopularSights = "Mather Point, Yavapai Observation Station, Eagle Point."
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "The national park consists of the Gateway Arch, a steel catenary arch that has become the definitive icon of St. Louis; a park along the Mississippi River on the site of the earliest buildings of the city; the Old Courthouse, a former state and federal courthouse, and the museum at the Gateway Arch.",
                            InterestingFacts = "The smallest US National Park. The Gateway Arch is the second largest monument in the world.",
                            Location = "St.Louis, Missouri",
                            Name = "Gateway Arch National Park",
                            PopularSights = "Gateway Arch, Old Courthouse, Tram to the top."
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C).",
                            InterestingFacts = "Badwater Basin’s salt flats is the North America's lowest point.",
                            Location = "California and Nevada States",
                            Name = "Death Valley National Park",
                            PopularSights = "Titus Canyon, Badwater Basin’s salt flats, Mesquite Flat Sand Dunes."
                        },
                        new
                        {
                            ParkId = 7,
                            Description = "	Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago.",
                            InterestingFacts = "The lake is the deepest in the United States and is noted for its vivid blue color and water clarity.",
                            Location = "Oregon State",
                            Name = "Crater Lake National Park",
                            PopularSights = "Pumice Desert, The Pinnacles, Mount Scott."
                        },
                        new
                        {
                            ParkId = 8,
                            Description = "The Haleakalā volcano on Maui features a very large crater with numerous cinder cones, a grove of non-native trees, the Kipahulu section's scenic pools of freshwater fish, and the endemic Hawaiian goose.",
                            InterestingFacts = "The park protects the greatest number of endangered species within a U.S. national park.",
                            Location = "Maui, Hawaii",
                            Name = "Haleakalā National Park",
                            PopularSights = "Kipahulu, Haleakalā Observatory, the summit."
                        },
                        new
                        {
                            ParkId = 9,
                            Description = "This park on the Big Island protects the Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features.",
                            InterestingFacts = "Diverse ecosystems range from tropical forests at sea level to barren lava beds at more than 13,000 feet",
                            Location = "Big Island, Hawaii",
                            Name = "Hawaiʻi Volcanoes National Park",
                            PopularSights = "Lava tube, Mokuaweoweo, Hawaiian Volcano Observatory"
                        },
                        new
                        {
                            ParkId = 10,
                            Description = "The highly glaciated mountains of the North Cascades Range exhibit a spectacular and complex geologic history.",
                            InterestingFacts = "Between the river valleys and high peaks there are eight diverse life zones with 75 mammal and 1,600 vascular plant species.",
                            Location = "Washington State",
                            Name = "North Cascades National Park",
                            PopularSights = "Ross Lake, Mount Shuksan, Lake Chelan."
                        },
                        new
                        {
                            ParkId = 11,
                            Description = "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus.",
                            InterestingFacts = "The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.",
                            Location = "Olympic Peninsula, Washington",
                            Name = "Olympic National Park",
                            PopularSights = "The Hoh Rainforest, Hurricane Ridge, Lake Crescent."
                        },
                        new
                        {
                            ParkId = 12,
                            Description = "This park protects the Giant Forest, which boasts some of the world's largest trees, the General Sherman being the largest measured tree in the park.",
                            InterestingFacts = "General Sherman tree is the largest tree on Earth by volume.",
                            Location = "California State",
                            Name = "Sequoia National Park",
                            PopularSights = "General Sherman tree, High Sierra Trail, Mount Whitney."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}