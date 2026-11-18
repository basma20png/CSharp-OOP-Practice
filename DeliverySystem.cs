using System;

namespace CSharpOOPPractice
{
    // Base Class (الكلاس الأساسي)
    public class Delivery
    {
        public string OrderId { get; set; }

        public Delivery(string orderId)
        {
            OrderId = orderId;
        }

        public virtual double CalculateCost()
        {
            return 0.0;
        }
    }

    // Derived Class 1: Car Delivery (التوصيل بالسيارة)
    public class CarDelivery : Delivery
    {
        public double DistanceKm { get; set; }

        public CarDelivery(string orderId, double distanceKm) : base(orderId)
        {
            DistanceKm = distanceKm;
        }

        public override double CalculateCost()
        {
            // تكلفة أساسية 10 + 1.5 لكل كيلومتر
            return 10.0 + (DistanceKm * 1.5);
        }
    }

    // Derived Class 2: Bike Delivery (التوصيل بالدراجة)
    public class BikeDelivery : Delivery
    {
        public double DistanceKm { get; set; }

        public BikeDelivery(string orderId, double distanceKm) : base(orderId)
        {
            DistanceKm = distanceKm;
        }

        public override double CalculateCost()
        {
            // تكلفة أساسية 5 + 0.8 لكل كيلومتر
            return 5.0 + (DistanceKm * 0.8);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // تطبيق تعدد الأشكال (Polymorphism) باستخدام مصفوفة من الكلاس الأساسي
            Delivery[] orders = new Delivery[]
            {
                new CarDelivery("ORD-101", 12.5),
                new BikeDelivery("ORD-102", 4.0),
                new CarDelivery("ORD-103", 8.0)
            };

            Console.WriteLine("=== Delivery System Cost Report ===");
            foreach (Delivery order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId} | Total Cost: ${order.CalculateCost():F2}");
            }
        }
    }
}
