//Si se ingresan E euros en el banco a un cierto interés I durante N años, el 
//dinero obtenido viene dado por la fórmula del interés compuesto: Resultado = e (1+ i)n
//Aplícalo para calcular en cuanto se convierten 1.000 euros al cabo de 10 años al 3% de interés anual.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int e=1000, i=3, n=10, resultado;
		
		i = ((i * e) / 100);
		resultado = e*((1+i)*n);
		Console.WriteLine(resultado);
	}
}
