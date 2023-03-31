using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InterestingFacts = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PopularSights = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "InterestingFacts", "Location", "Name", "PopularSights" },
                values: new object[,]
                {
                    { 1, "Mount Rainier National Park, a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier.", "Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams.", " Washington state", "Mount Rainier National Park", "Paradise, Longmire, Sunrise." },
                    { 2, "Yosemite National Park is in California’s Sierra Nevada mountains. It’s famed for its giant, ancient sequoia trees, and for Tunnel View, the iconic vista of towering Bridalveil Fall and the granite cliffs of El Capitan and Half Dome.", "Of California's 7,000 plant species, approximately 50 percent occur in the Sierra Nevada and more than 20 percent are within Yosemite.", " California state", "Yosemite National Park", "El Capitan, Half Dome, The Tunnel View." },
                    { 3, "Joshua Tree National Park is a vast protected area in southern California. It's characterized by rugged rock formations and stark desert landscapes. Named for the region’s twisted, bristled Joshua trees, the park straddles the cactus-dotted Colorado Desert and the Mojave Desert, which is higher and cooler.", "Joshua Tree is a popular observing site in Southern California for amateur astronomy and stargazing.", "Southern California", "Joshua Tree National Park", "Giant Marbles, Hidden Valley, Cholla Cactus Garden." },
                    { 4, "Grand Canyon National Park, in Arizona, is home to much of the immense Grand Canyon, with its layered bands of red rock revealing millions of years of geological history.", "The canyon was created by the incision of the Colorado River and its tributaries after the Colorado Plateau was uplifted, causing the Colorado River system to develop along its present path", "Arizona State", "Grand Canyon National Park", "Mather Point, Yavapai Observation Station, Eagle Point." },
                    { 5, "The national park consists of the Gateway Arch, a steel catenary arch that has become the definitive icon of St. Louis; a park along the Mississippi River on the site of the earliest buildings of the city; the Old Courthouse, a former state and federal courthouse, and the museum at the Gateway Arch.", "The smallest US National Park. The Gateway Arch is the second largest monument in the world.", "St.Louis, Missouri", "Gateway Arch National Park", "Gateway Arch, Old Courthouse, Tram to the top." },
                    { 6, "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C).", "Badwater Basin’s salt flats is the North America's lowest point.", "California and Nevada States", "Death Valley National Park", "Titus Canyon, Badwater Basin’s salt flats, Mesquite Flat Sand Dunes." },
                    { 7, "	Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago.", "The lake is the deepest in the United States and is noted for its vivid blue color and water clarity.", "Oregon State", "Crater Lake National Park", "Pumice Desert, The Pinnacles, Mount Scott." },
                    { 8, "The Haleakalā volcano on Maui features a very large crater with numerous cinder cones, a grove of non-native trees, the Kipahulu section's scenic pools of freshwater fish, and the endemic Hawaiian goose.", "The park protects the greatest number of endangered species within a U.S. national park.", "Maui, Hawaii", "Haleakalā National Park", "Kipahulu, Haleakalā Observatory, the summit." },
                    { 9, "This park on the Big Island protects the Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features.", "Diverse ecosystems range from tropical forests at sea level to barren lava beds at more than 13,000 feet", "Big Island, Hawaii", "Hawaiʻi Volcanoes National Park", "Lava tube, Mokuaweoweo, Hawaiian Volcano Observatory" },
                    { 10, "The highly glaciated mountains of the North Cascades Range exhibit a spectacular and complex geologic history.", "Between the river valleys and high peaks there are eight diverse life zones with 75 mammal and 1,600 vascular plant species.", "Washington State", "North Cascades National Park", "Ross Lake, Mount Shuksan, Lake Chelan." },
                    { 11, "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus.", "The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.", "Olympic Peninsula, Washington", "Olympic National Park", "The Hoh Rainforest, Hurricane Ridge, Lake Crescent." },
                    { 12, "This park protects the Giant Forest, which boasts some of the world's largest trees, the General Sherman being the largest measured tree in the park.", "General Sherman tree is the largest tree on Earth by volume.", "California State", "Sequoia National Park", "General Sherman tree, High Sierra Trail, Mount Whitney." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
