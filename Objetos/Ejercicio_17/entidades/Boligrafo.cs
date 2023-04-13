namespace entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        private void SetTinta(short tinta) 
        {
            this.tinta += tinta;

            if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if(this.tinta < 0)
            {
                this.tinta = 0;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        
        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = "";

            if(this.tinta == 0)
            {
                dibujo = "No se pudo pintar";
                return false;
            }
            else
            {
                while (gasto > 0 && this.tinta > 0)
                {
                    cadenaAux = cadenaAux + "*";
                    this.SetTinta(-1);
                    gasto--;
                }
                dibujo = cadenaAux;
                return true;
            }
            
            
        }
        

    }
}