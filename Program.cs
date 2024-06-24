//<>//
using EspacioCalculadora;
Calculadora nuevaCalculadora = new Calculadora();
int seguir = 1,numeroCalculo = 1;
do{
    double valorAnterior = nuevaCalculadora.Resultado;
    Console.WriteLine("-----------------------------");
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
    if(int.TryParse(opcionC, out opcion)){
        if(opcion >= 1 && opcion <= 6){
            double resultadoAnterior = nuevaCalculadora.Resultado;
            double nuevoValor = 0;
            int cargar = 1;
            TipoOperacion operacionEfectuada = TipoOperacion.Suma;
            if(opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4){
                Console.WriteLine("ingrese un numero");
                string numeroCadena = Console.ReadLine();
                int numero = 0;
                if(int.TryParse(numeroCadena,out numero)){
                    switch(opcion){
                        case 1:
                        nuevaCalculadora.sumar(numero);
                        operacionEfectuada = TipoOperacion.Suma;
                        nuevoValor = numero;
                        break;

                        case 2:
                        nuevaCalculadora.restar(numero);
                        operacionEfectuada = TipoOperacion.Resta;
                        nuevoValor = numero;
                        break;

                        case 3:
                        nuevaCalculadora.multiplicar(numero);
                        operacionEfectuada = TipoOperacion.Multiplicacion;
                        nuevoValor = numero;
                        break;

                        case 4:
                        if(numero != 0){
                        nuevaCalculadora.dividir(numero);
                        operacionEfectuada = TipoOperacion.Division;
                        nuevoValor = numero;
                        }
                        else{
                            Console.WriteLine("no se puede dividir en 0");
                            cargar = 0;
                        }
                        break;
                    }
                }
            }
            else if(opcion == 5){
                nuevaCalculadora.limpiar();
                operacionEfectuada = TipoOperacion.Limpiar;
                nuevoValor = 0;
            }
            else if(opcion == 6){
                nuevaCalculadora.mostrarHistorial();
                cargar = 0;
            }
            if(cargar == 1){
                Operacion nuevoCalculo = new Operacion(resultadoAnterior,nuevoValor,operacionEfectuada,nuevaCalculadora.Resultado,numeroCalculo);
                nuevaCalculadora.historial.Add(nuevoCalculo);
                numeroCalculo++;
            }
        }
        else if(opcion == 7){
            Console.WriteLine("saliendo....");
            seguir = 0;
        }
        else{
            Console.WriteLine("no se eligio una opcion valida");
        }        
    }
}while(seguir == 1);