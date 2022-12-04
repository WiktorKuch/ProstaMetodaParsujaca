namespace ProstaMetodaParsujaca
{
    class Program
    {
        static void Main(string[] args)
        {
            int horsePower1 = 350;
            int horsePower2 = 350;

            bool valueTypeEquality = horsePower1== horsePower2;
            bool valueType = horsePower1.Equals(horsePower2);

            Car car1 = new Car(horsePower1);
            Car car2 = new Car(horsePower2);

            bool referenceTypeEquality = car1 == car2;
            bool referenceType = car1.Equals(car2);

            Console.WriteLine($"valueTypeEquality: {valueTypeEquality}");
            Console.WriteLine($"valueTypeEquality: {valueType}");

            Console.WriteLine($"referenceTypeEquality : {referenceTypeEquality}");
            Console.WriteLine($"referenceTypeEquality : {referenceType}");


        }
    }

    class Car
    {
        public static bool operator ==( Car left, Car right)
        {
             return Equals( left , right );
        }

        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(this.GetType() != obj.GetType())
            {
                return false;
            }

            Car carObj = (Car)obj;
            return this.HorsePower == carObj.HorsePower;
        }
        public Car(int horsePower) 
        {

            HorsePower = horsePower;
        }

        public int HorsePower { get; set; }
    }
}