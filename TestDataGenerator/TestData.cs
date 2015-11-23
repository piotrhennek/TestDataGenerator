namespace TestDataGenerator
{
    public class TestData
    {
        public static string[] ProductName =
        {
            "Xbox 360",
            "Xbox One",
            "Nintendo 64",
            "Wii U",
            "Ouya",
            "Nintendo 3DS",
            "PlayStation Vita",
            "PlayStation 4",
            "Xbox One",
            "Game Wave",
            "Atari Flashback 2",
            "Generation NEX",
            "FC Twin Video System",
            "Sony PlayStation 3  ",
            "Nintendo Wii",
            "Microsoft Xbox 360",
            "Mattel HyperScan",
            "Evo: Phase One",
            "Phantom Game Console",
            "XGP 2007",
            "GP2X",
            "Gizmondo",
            "Sony PlayStation",
            "Nintendo DS",
            "Nintendo DS Lite",
            "Nintendo DSi"
        };

        public static string[] ProductDescription =
        {
            " is a wonderful console",
            " was developed in 2000",
            " is the most popular console",
            " is a very cheap console",
            " is the best console",
            " was constructed in Japan",
            " is a 8th generation console",
            " was released in 2015"
        };

        public static string[,] OrderStatusNameAndDescription =
        {
            { "Pending","customer started the checkout process" },
            {"Awaiting Payment","customer has completed checkout process" },
            {"Fulfillment","customer has completed the checkout" },
            {"Shipment","order has been pulled and packaged" },
            {"Pickup","order has been pulled" },
            {"Partially","only some items in the order have been shipped" },
            {"Completed","order has been shipped/picked up" },
            {"Shipped","order has been shipped" },
            {"Cancelled","seller has cancelled an order" },
            {"Declined","seller has marked the order as declined" },
            {"Refunded","seller has used the Refund action" },
            {"Disputed","customer has initiated a dispute resolution process " },
            { "Verification","order on hold while some aspect" }
        };

        public static string[] DeliveryName =
        {
            "Standard delivery",
            "Express delivery",
            "Super express delivery",
            "Normal delivery"
        };

        public static int[] DeliveryTime =
      {
            4,
            2,
            1,
            5
        };

        public static double[] DeliveryPrice =
        {
            19.99,
            25.99,
            35.99,
            15.99
        };

        public static string[] EmailDomen =
        {
            "gmail.com",
            "yahoo.com",
            "hotmail.com",
            "mail.com",
            "yourmail.com",
            "testmail.com"
        };

        public static string[] Firstname =
        {
            "John",
            "Stephen",
            "Mark",
            "David",
            "Barack",
            "Elizabeth",
            "Carla",
            "Victoria",
            "Salma",
            "Sandra",
            "Nicole",
            "Miriam"
        };

        public static string[] Surname =
        {
            "Smith",
            "Johnson",
            "Wiliams",
            "Brown",
            "Jones",
            "Miller",
            "Davis",
            "Garcia",
            "Rodrigez",
            "Wilson"
        };

        public static string[,] DepartmentNameAndDescription =
        {
            {"Production","Responsible for converting inputs into outputs through the stages" },
            {"Stores","The stores department are responsible for stocking all the necessary tools" },
            {"Human resource" ,"The role of Human resource department is in charge of recruiting of employees"},
            {"Marketing","Responsible for market research and testing new products" },
            {"Sales","Is responsible for the sales and distribution of the products" },
            {"Finance","Keeping records of the purchases and sales made by a business" }
        };

        public static string[,] PositionNameAndDescription =
        {
            {"Manager","It is a Manager" },
            {"Chief","It is a Chief" },
            {"Department chief","It is a Department chief" },
            {"Engineer","It is a Engineer" },
            {"Supervisor","It is a Supervisor" },
            {"Support","It is a Support" },
            { "Service","It is a Service" }
        };

        public static string[] Cities =
        {
            "Washington",
            "New York",
            "Miami",
            "Ohio",
            "Los Angeles"
        };

        public static string[] Streets =
     {
            "Obama Street",
            "Bush Street",
            "Johaness Paul 2 Street",
            "Brooklyn",
            "Kenedy Street"
        };
    }
}
