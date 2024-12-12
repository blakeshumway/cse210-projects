using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2540 milkdrive", "dallas texas", "US", true);
        Customer customer1 = new Customer("Mike", address1);
        Order order1 = new Order(customer1);
        order1.AddItem("Apple", 253, 1, 3);
        order1.AddItem("Eggs", 572, 1.50, 3);
        order1.AddItem("Ham", 253, 3.75, 3);

        Address address2 = new Address("Emilsgate 6", "Oppgang", "Norway", false);
        Customer customer2 = new Customer("Mike", address2);
        Order order2 = new Order(customer2);
        order2.AddItem("Markers", 456, 5.50, 2);
        order2.AddItem("Bread", 111, 2.49, 5);
        order2.AddItem("Yam", 789, 8.69, 2);
        order2.AddItem("Spam", 274, 3.45, 1);


        order1.DisplayAll();

        order2.DisplayAll();

    }
}