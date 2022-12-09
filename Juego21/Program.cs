//array con simbolso de cartas segun valor 
string[] simbolosCarta = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

//ARRAY con cartas, 
string[] baraja = new string[52];
//Mirar en cada carta del array, crear valor igual a simbolo de carta segun el numero
for (int i = 0; i < baraja.Length; i++)
{
    //establece simbolo 0-12♠ 13-25♣ 26-38♦ 39-51♥
    string simbolo;
    if (i <= 12) {simbolo = "♠";}
    else if (i <= 25) { simbolo = "♣"; }
    else if (i <= 38) { simbolo = "♦"; }
    else { simbolo = "♥"; }
    //establece numero
    int numero = (i+1) % 13;
    //La carta 13 valdria 0 por el operador %
    if (numero == 0) { numero = 13; }
    //organiza el string para que quede como la carta
    string numeroCarta = simbolosCarta[numero - 1]+simbolo;
    baraja[i] = numeroCarta;
}

