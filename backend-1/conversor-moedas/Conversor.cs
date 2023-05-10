namespace conversor_moedas
{
    public static class Conversor
    {

        public static float Dolar { get; set; } = 4.99F;
        public static float Real { get; set; } = 0.20F;
        public static float Valor { get; set; }
        
        
        public static float DolarParaReal(float Dolar){

            Valor = Dolar;
            
            return Valor / Real;
        }
        public static float RealParaDolar(float Real){

            Valor = Real;
            
            return Valor * Dolar;
        }
    }
}