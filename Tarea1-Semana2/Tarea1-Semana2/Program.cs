
using Tarea1_Semana2.Modelos;

List<ExpresionMatematica> Expresiones = new List<ExpresionMatematica>();


ExpresionMatematica EXP1 = new ExpresionMatematica()
{
    numero1 = 2,
    numero2 = 3
};
ExpresionMatematica EXP2 = new ExpresionMatematica()
{
    numero1 = 10,
    numero2 = 5
};
Expresiones.Add(EXP1);
Expresiones.Add(EXP2);

EXP1.Suma();
EXP1.Resta();
EXP1.Divison();
EXP1.Multiplicacion();
EXP1.Maximo();
EXP1.Minimo();

EXP2.Suma();
EXP2.Resta();
EXP2.Divison();
EXP2.Multiplicacion();
EXP2.Maximo();
EXP2.Minimo();

foreach (ExpresionMatematica x in Expresiones)
{
    
    Console.WriteLine(x.toString());
}


