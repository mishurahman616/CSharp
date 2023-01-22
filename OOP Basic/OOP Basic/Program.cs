using OOP_Basic;

WaterBottle waterBottle = new WaterBottle("Red", 200);
waterBottle.WaterAmount = 100;
waterBottle.AddWater(5);
Console.WriteLine(waterBottle.WaterAmount);
Console.WriteLine(waterBottle.Color);
Console.WriteLine(waterBottle.IsOpen);
waterBottle.ShowBottoleInformation();



