//<>//
using EspacioCalculadora;
Calculadora nuevaCalculadora = new Calculadora();
int seguir = 1,numeroCalculo = 1;
do{
    double valorAnterior = nuevaCalculadora.Resultado;
    Console.WriteLine("valor actual: "+nuevaCalculadora.Resultado);
    Console.WriteLine("1: sumar un numero");
    Console.WriteLine("2: restar un numero");
    Console.WriteLine("3: multiplicar un numero");
    Console.WriteLine("4: dividir un numero");
    Console.WriteLine("5: limpiar");
    Console.WriteLine("6: historial");
    Console.WriteLine("7: salir");
    Console.WriteLine("ingrese una opcion:");
    string opcionC = Console.ReadLine();
    int opcion = 0;
    if(int.TryParse(opcionC,out opcion)){
        if(opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 6){
            Console.WriteLine("ingrese un numero");
            string numeroC = Console.ReadLine();
            int numero = 0;
            if(int.TryParse(numeroC,out numero)){
                double nuevoValor = 0;
                int cargar = 1;
                TipoOperacion operacion = TipoOperacion.Suma;
                switch(opcion){
                    case 1:
                    nuevaCalculadora.sumar(numero); 
                    nuevoValor = numero;
                    operacion = TipoOperacion.Suma;
                    break;

                    case 2:
                    nuevaCalculadora.restar(numero); 
                    nuevoValor = numero;
                    operacion = TipoOperacion.Resta;
                    break;

                    case 3:
                    nuevaCalculadora.multiplicar(numero); 
                    nuevoValor = numero;
                    operacion = TipoOperacion.Multiplicacion;
                    break;

                    case 4: 
                    nuevaCalculadora.dividir(numero); 
                    if(numero != 0){
                        nuevoValor = numero;
                        operacion = TipoOperacion.Division;
                    }
                    else{
                        cargar = 0;
                    }
                    break;

                    case 5:
                    nuevaCalculadora.limpiar();
                    nuevoValor = 0;
                    operacion = TipoOperacion.Limpiar;
                    break;

                    case 6:
                    nuevaCalculadora.mostrarHistorial();
                    cargar = 0;
                    break;
                }
                if(cargar == 1){
                    double resultado = nuevaCalculadora.Resultado;
                    Operacion calculo = new Operacion(valorAnterior,nuevoValor,operacion,resultado,numeroCalculo);
                    nuevaCalculadora.historial.Add(calculo);
                    numeroCalculo++;
                }
            }
            else{
                Console.WriteLine("no se ingreso un numero valido");
            }
        }
        else if(opcion < 1 || opcion > 6){
            seguir = 0;
        }
        else{
        Console.WriteLine("no se ingreso un numero");
        }
}}while(seguir == 1);
Console.WriteLine("resultado final: "+nuevaCalculadora.Resultado);

