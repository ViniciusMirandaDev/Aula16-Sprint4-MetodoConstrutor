namespace Aula16_Sprint4_MetodoConstrutor
{
    public class Heroi
    {
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public string Nome { get; set; }
        public string Especial { get; set; }



        public Heroi(){
        
        }
        public Heroi(int _vida){
            this.Vida       = _vida;
        }
        public Heroi(string _nome, int _vida, int _ataque, string _especial){

            this.Nome       = _nome;
            this.Vida       = _vida;
            this.Ataque     = _ataque;
            this.Especial   = _especial;
        }
    }
}