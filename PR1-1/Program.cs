Console.WriteLine("Результаты гонок: ");
auto car_1 = new auto(180, "granta");
Console.WriteLine("Машина " + car_1.nameAuto + " ехавшая со скоростью " + car_1.maxSpeed + " занимает последнее место");

auto car_2 = new auto(200, "camaro");
Console.WriteLine("Машина " + car_2.nameAuto + " ехавшая со скоростью " + car_2.maxSpeed + " занимает третье место");

auto car_3 = new auto(220, "porsh");
Console.WriteLine("Машина " + car_3.nameAuto + " ехавшая со скоростью " + car_3.maxSpeed + " занимает второе место");

auto car_4 = new auto(240, "lamborgini");
Console.WriteLine("Машина " + car_4.nameAuto + " ехавшая со скоростью " + car_4.maxSpeed + " занимает первое место и становится побидителем");

Console.ReadKey(true);


class auto
{
    public double maxSpeed;
    public string nameAuto;

    public auto(double maxSpeed, string nameAuto)
    {
        this.maxSpeed = maxSpeed;
        this.nameAuto = nameAuto;
    }
}