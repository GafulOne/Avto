public class Avto
{
    private string Number; // Номер машины
    private int TopFuel; // Вместимость бака автомобиля
    private double Fuel; // Количество топлива в баке
    private double Ras; // Расход топлива на 100км
    private double Distance; // Растояние
    private double Milleage; //Пробег


    public Avto(string Number, int TopFuel, double Fuel, double Ras) //Конструктор класса
    {
        this.Number = Number;
        this.Fuel = Fuel;
        this.Ras = Ras;
        this.TopFuel = TopFuel;
        this.Milleage = 0;
    }

    public void Out() //Метод выводы информации о машне
    {
        Console.WriteLine($"Номер машины: {Number} \nВместимость бака: {TopFuel} \nКоличество топлива в баке: {Fuel} \nРасход топлива на 100км: {Ras}");
    }

    public void Refuel() // Метод заправки автомобиля
    {
        Console.WriteLine($"На сколько литров вы хотите заправиться? Максимально количество {TopFuel}. Топлива в баке: {Fuel}");
        double Amount = Convert.ToDouble(Console.ReadLine());
        if (Fuel + Amount <= TopFuel) 
        {
            Fuel += Amount;
            Console.WriteLine($"Вы заправились на {Amount} литров. Текущее количество топлива {Fuel}");
        }
        else
        {
            Console.WriteLine("Бак переполнен");
        }
    }

    public void Drive(double Distance) //Метод езды автомобиля
    {

        while (Milleage != Distance) //цикл пока пробег не равен заданной дистанции
        {
            Fuel -= Ras;
            Milleage += 100;
            Console.WriteLine($"Пройдено {Milleage}. Остаток топлива в баке: {Fuel}");
            if (Fuel < 0)
            {
                Console.WriteLine("У вас кончилось топливо");
                return;
            }
            if (Fuel < Ras)
            {
                Console.WriteLine($"Недостаточно топлива чтобы проехать {Distance} км. Заправьте машину");
                this.Refuel();
            }
        }
    }
}