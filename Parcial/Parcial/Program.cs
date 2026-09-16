
Console.WriteLine("Ingrese la calificacion del primer parcial");
double califacion1 = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese la calificacion del segundo parcial");
double califiacion2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el porcentaje de asistencia:");
double porcentaje = double.Parse(Console.ReadLine());

Console.WriteLine("Ingree el nivel de curso\n" +
    "1" +
    "\n2" +
    "\n3 :");
int curso = int.Parse(Console.ReadLine());


double promedio = (califacion1 + califiacion2) / 2;
double bonificacion = porcentaje * 0.05;



String alumno;
if (promedio < 60 || porcentaje < 70)
{
    alumno = "reprobado";
}
else
{
    alumno = "aprobado";
}

string candidato;
if (califacion1 >= 90 && califiacion2 >= 90)
{
    candidato = " Candidato por Excelencia";
}
else
{
    candidato = "No fue candidato";
}
string categoria;

double final = promedio + bonificacion;

if (curso == 1) { categoria = "Primera"; }
else if (curso == 2) { categoria = "segunda"; }
else { categoria = "tercera"; }

string mencion;

if (final >= 90 && porcentaje > 70) { mencion = "Cuadro de honor"; }
else if (final >= 80 && porcentaje > 70) { mencion = "Mencion honorifica"; }
else { mencion = "No tiene mencion honorifica"; }



Console.WriteLine($"Su calificacion final es: {final}");
Console.WriteLine($"Estado academico: {alumno}");
Console.WriteLine($"Mencion Honorifica: {mencion}");
Console.WriteLine($"Categoria de certificacion: {categoria}");
