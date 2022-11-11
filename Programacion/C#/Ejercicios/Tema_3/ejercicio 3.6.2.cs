//Crea una enumeración para los meses del año, desde ENERO (con valor 1) 
//hasta DICIEMBRE (con valor 12). Muestra el valor numérico correspondiente a OCTUBRE.
// Ruben Martinez Martinez

using System;
class ej{
	enum mes{ Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
	static void Main(){
		Console.WriteLine("Octubre corresponde al valor: {0}",(int) mes.Octubre);
	}
}
