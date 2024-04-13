using Clase_13_abril_24.ClaseHija;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamientoo = 2017;
nintendo.Marca = "Switch";
nintendo.anioLanzamiento = true;
Console.WriteLine(nintendo.MostrarDetalleNintendo());

//Instancia de ps1
Playstation ps = new Playstation();

ps.ModeloCotrolador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

xBox xBox = new xBox();
xBox.color = "amarillo";
SegaDreamCast segaDreamCast = new SegaDreamCast();
segaDreamCast.color = "rojo";