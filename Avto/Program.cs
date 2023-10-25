namespace ClassDZ
{
    class Program
    {
        static void Main()
        {
            Avto car = new Avto("AV123C", 50, 20, 7); // Номер машины, Вместимость бака автомобиля, Количество топлива в баке, Расход топлива на 10км

            car.Out(); //Вывод информации о машине
            Console.WriteLine("Укажите расстояние для поездки:");
            double distance = Convert.ToDouble(Console.ReadLine());

            car.Drive(distance);
        }
    }
}
