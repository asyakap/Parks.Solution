using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class ParksContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksContext(DbContextOptions<ParksContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Parks>()
        .HasData(
          new Park { ParkId = 1, Name = "Mount Rainier National Park", Location = " Washington state", Description = "Mount Rainier National Park, a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier.", InterestingFacts = "Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams.", PopularSights = "Paradise, Longmire, Sunrise." },

          new Park { ParkId = 2, Name = "Yosemite National Park", Location = " California state", Description = "Yosemite National Park is in California’s Sierra Nevada mountains. It’s famed for its giant, ancient sequoia trees, and for Tunnel View, the iconic vista of towering Bridalveil Fall and the granite cliffs of El Capitan and Half Dome.", InterestingFacts = "Of California's 7,000 plant species, approximately 50 percent occur in the Sierra Nevada and more than 20 percent are within Yosemite.", PopularSights = "El Capitan, Half Dome, The Tunnel View." },

          new Park { ParkId = 3, Name = "Joshua Tree National Park", Location = "Southern California", Description = "Joshua Tree National Park is a vast protected area in southern California. It's characterized by rugged rock formations and stark desert landscapes. Named for the region’s twisted, bristled Joshua trees, the park straddles the cactus-dotted Colorado Desert and the Mojave Desert, which is higher and cooler.", InterestingFacts = "Joshua Tree is a popular observing site in Southern California for amateur astronomy and stargazing.", PopularSights = "Giant Marbles, Hidden Valley, Cholla Cactus Garden."},

          new Park { ParkId = 4, Name = "Grand Canyon National Park", Location = "Arizona State", Description = "Grand Canyon National Park, in Arizona, is home to much of the immense Grand Canyon, with its layered bands of red rock revealing millions of years of geological history.", InterestingFacts = "The canyon was created by the incision of the Colorado River and its tributaries after the Colorado Plateau was uplifted, causing the Colorado River system to develop along its present path", PopularSights = "Mather Point, Yavapai Observation Station, Eagle Point."},

          new Park { ParkId = 5, Name = "Gateway Arch National Park", Location = "St.Louis, Missouri", Description = "The national park consists of the Gateway Arch, a steel catenary arch that has become the definitive icon of St. Louis; a park along the Mississippi River on the site of the earliest buildings of the city; the Old Courthouse, a former state and federal courthouse, and the museum at the Gateway Arch.", InterestingFacts = "The smallest US National Park. The Gateway Arch is the second largest monument in the world.", PopularSights = "Gateway Arch, Old Courthouse, Tram to the top."},
          
          new Park { ParkId = 6, Name = "Death Valley National Park", Location = "California and Nevada States", Description = "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C).", InterestingFacts = "Badwater Basin’s salt flats is the North America's lowest point.", PopularSights = "Titus Canyon, Badwater Basin’s salt flats, Mesquite Flat Sand Dunes."},

          new Park { ParkId = 7, Name = "Crater Lake National Park", Location = "Oregon State", Description = "	Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago.", InterestingFacts = "The lake is the deepest in the United States and is noted for its vivid blue color and water clarity.", PopularSights = "Pumice Desert, The Pinnacles, Mount Scott."},

          new Park { ParkId = 8, Name = "Haleakalā National Park", Location = "Maui, Hawaii", Description = "The Haleakalā volcano on Maui features a very large crater with numerous cinder cones, a grove of non-native trees, the Kipahulu section's scenic pools of freshwater fish, and the endemic Hawaiian goose.", InterestingFacts = "The park protects the greatest number of endangered species within a U.S. national park.", PopularSights = "Kipahulu, Haleakalā Observatory, the summit."},

          new Park { ParkId = 9, Name = "Hawaiʻi Volcanoes National Park", Location = "Big Island, Hawaii", Description = "This park on the Big Island protects the Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features.", InterestingFacts = "Diverse ecosystems range from tropical forests at sea level to barren lava beds at more than 13,000 feet", PopularSights = "Lava tube, Mokuaweoweo, Hawaiian Volcano Observatory"},

          new Park { ParkId = 10, Name = "North Cascades National Park", Location = "Washington State", Description = "The highly glaciated mountains of the North Cascades Range exhibit a spectacular and complex geologic history.", InterestingFacts = "Between the river valleys and high peaks there are eight diverse life zones with 75 mammal and 1,600 vascular plant species.", PopularSights = "Ross Lake, Mount Shuksan, Lake Chelan."},
           new Park { ParkId = 11, Name = "Olympic National Park", Location = "Olympic Peninsula, Washington", Description = "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus.", InterestingFacts = "The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.", PopularSights = "The Hoh Rainforest, Hurricane Ridge, Lake Crescent."},

           new Park { ParkId = 12, Name = "Sequoia National Park", Location = "California State", Description = "This park protects the Giant Forest, which boasts some of the world's largest trees, the General Sherman being the largest measured tree in the park.", InterestingFacts = "General Sherman tree is the largest tree on Earth by volume.", PopularSights = "General Sherman tree, High Sierra Trail, Mount Whitney."}
        );
    }
  }
}