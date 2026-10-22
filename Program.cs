using LAB05;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Point point1 = new Point(3, 4);

Console.WriteLine("Исходные координаты:");
point1.PrintPoint();

Console.WriteLine($"Расстояние до начала координат: {point1.DistanceToOrigin()}");

point1.MoveTo(6, 8);

Console.WriteLine("Координаты после перемещения:");
point1.PrintPoint();

Console.WriteLine($"Новое расстояние: {point1.DistanceToOrigin()}");

Point point2 = new Point(-3, -4);

Console.WriteLine("Вторая точка:");
point2.PrintPoint();

Console.WriteLine($"Расстояние до начала координат: {point2.DistanceToOrigin()}");
