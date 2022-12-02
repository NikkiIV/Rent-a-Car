namespace RentACar.Data
{
    public class DataConstants
    {
        public class Car
        { 
            public const int CarBrandMaxLenght = 20;
            public const int CarModelMaxLenght = 30;
        }
        public class Dealer
        {
            public const int DealerNameMinLength = 2;
            public const int DealerNameMaxLength = 30;
            public const int DealerPhoneMinLength = 6;
            public const int DealerPhoneMaxLength = 30;
        }

        public class User
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 40;
        }

        public class Category
        {
            public const int CategoryNameMaxLength = 25;
        }
    }
}
