using classes_estaticas;

float resultadoFahreheint = ConversorTemperatura.CelsiusParaFahreheint(24);
float resultadoCelsius = ConversorTemperatura.FahreheintParaCelsius(70);

Console.WriteLine($"Celsius: {resultadoCelsius}");
Console.WriteLine($"Fahreheint: {resultadoFahreheint}");