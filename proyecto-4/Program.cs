using System.ComponentModel.Design;

Console.WriteLine("EJERCICIO_1");                                    //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

double suma = 0;

for (int  i = 1;  i <= 5;  i++)
{
    Console.Write($"Ingrese la calificación:  {i}: ");
    double calificacion = Convert.ToDouble(Console.ReadLine());
suma = suma + calificacion;
}


double promedio = (suma) / 5.0;

Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");
Console.WriteLine();

if (promedio <= 50)
{
    Console.WriteLine($"alumno deficiente");
}
else if (promedio == 51 && promedio <= 69)
{
    Console.WriteLine($"alumno requiere apoyo");
}
else if (promedio == 70 && promedio <= 79)
{
    Console.WriteLine($"alumno regular");
}
else if (promedio == 80 && promedio <= 89)
{
    Console.WriteLine($"alumno bueno");
}
else if (promedio == 90 && promedio <= 100)
{
    Console.WriteLine($"alumno sobresaliente");
}
else
{
    Console.WriteLine($"alumno excelente");
}