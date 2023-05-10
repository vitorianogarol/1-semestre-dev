namespace classes_estaticas
{
    public static class ConversorTemperatura
    {
        //propriedade estatica
        public static float temperatura { get; set; }

        //metodo estatico
        public static float CelsiusParaFahreheint(float celsius)
        {
            temperatura = celsius;

            float fahreheint = (temperatura * 9 / 5) + 32;

            return fahreheint;
        }

        public static float FahreheintParaCelsius(float fahreheint)
        {

            temperatura = fahreheint;

            float celsius = (temperatura - 32) * 5 / 9;

            return celsius;
        }
    }
}