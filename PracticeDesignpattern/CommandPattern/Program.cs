namespace CommandPattern
{
    // Builder pattern

    public class Program
    {
        static void Main(string[] args)
        {
            //HouseDirector houseDirector = new();
            //IHouseBuilder luxuryBuilder = new LuxutyHouseBuilder();
            //List<string> lstAmenities = ["Swimming Pool", "Home Thetre", "Garden"];

            //// Construct luxury house
            //houseDirector.Construct(luxuryBuilder, 3, true, lstAmenities);
            //House house = luxuryBuilder.GetHouse();
            //house.Display();
        }
    }

    /// <summary>
    /// Representing The Blueprint For The Final Product
    /// </summary>
    public class House
    {
        public int Bedroom { get; set; }
        public bool HasGarrage { get; set; }
        public List<string> Amenitis { get; set; } = null;
        public void Display()
        {
            Console.WriteLine($"House Details Bedroom : {Bedroom} and Garrage {(HasGarrage ? "Yes" : "No")}");
        }
    }

    /// <summary>
    /// Object creation
    /// </summary>
    public class HouseDirector
    {
        public static void Construct(IHouseBuilder builder, int noOfBedroom, bool hasGarrage, List<string> amenities)
        {
            builder.BuildBedroom(noOfBedroom);
            builder.BuildGarage(hasGarrage);
            builder.BuildAmenities(amenities);
        }
    }
    /// <summary>
    /// Defining Methods for configuring house
    /// </summary>
    public class LuxutyHouseBuilder : IHouseBuilder
    {
        House house = new();

        public void BuildBedroom(int noOfBedroom)
        {
            house.Bedroom = noOfBedroom;
        }

        public void BuildGarage(bool hasGarage)
        {
            house.HasGarrage = hasGarage;
        }
        public void BuildAmenities(List<string> amenities)
        {
            house.Amenitis = amenities;
        }

        public House GetHouse()
        {
            return house;
        }
    }

    public interface IHouseBuilder
    {
        void BuildBedroom(int noOfBedroom);
        void BuildGarage(bool hasGarage);
        void BuildAmenities(List<string> amenities);
        House GetHouse();
    }
}
