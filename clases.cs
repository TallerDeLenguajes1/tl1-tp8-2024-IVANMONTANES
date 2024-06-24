namespace EspacioCalculadora
{

    public enum TipoOperacion{
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }

    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;
        private double resultado;
        private int numeroCalculo;

        public Operacion(double ResultadoAnterior, double NuevoValor, TipoOperacion Operacion, double Resultado, int NumeroCalculo){
            resultadoAnterior = ResultadoAnterior;
            nuevoValor = NuevoValor;
            operacion = Operacion;
            resultado = Resultado;
            this.NumeroCalculo = NumeroCalculo;
        }

        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion Operacio { get => operacion; set => operacion = value; }
        public double Resutlado { get => resultado; set => resultado = value; }
        public int NumeroCalculo { get => numeroCalculo; set => numeroCalculo = value; }
    }

    public class Calculadora{
        private double dato;

        public List<Operacion> historial = new List<Operacion>();

        //funcion para sumar//
        public void sumar(double termino){
            dato += termino;
        }

        //funcion para restar//
        public void restar(double termino){
            dato -= termino;
        }

        //funcion para multiplicar//
        public void multiplicar(double termino){
            dato *= termino;
        }

        //funcion para dividir//
        public void dividir(double termino){
            if(termino != 0){
                dato /= termino;
            }
            else{
                Console.WriteLine("no se puede dividir en 0");
            }
        }

        //funcion para limpiar//
        public void limpiar(){
            dato = 0;
        }

        public double Resultado{
            get => dato;
        }

        public void mostrarHistorial(){
            int cantidadElementos = historial.Count();
            Console.WriteLine("-------------------------HISTORIAL-------------------------");
            if(cantidadElementos == 0){
                Console.WriteLine("-------------------------la lista esta vacia-------------------------");
            }
            else{
            foreach(var item in historial){
                Console.WriteLine("----------CALCULO "+item.NumeroCalculo+"----------");
                Console.WriteLine("resultado anterior: "+item.ResultadoAnterior);
                Console.WriteLine("nuevo valor: "+item.NuevoValor);
                Console.WriteLine("tipo operacion: "+item.Operacio);
                Console.WriteLine("resultado: "+item.Resutlado);
            }
            }
        }
    
    }
}