/* Assegnazione
 - Costruire una lista (li) di 1000 numeri casuali compresi tra 0 e 999 incluso
 - Costruire un SortedSet (ssi) contenente i numeri già presenti in lista
 - Costruire un vettore di booleani (vb), lungo 1000, che per ogni intero n presente in lista
   vale vb[n]=true

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nel vettore vb (quindi if vb[n] == true). Non dovete stampare nulla

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nella lista li (quindi li.find...). Non dovete stampare nulla

 - calcolare quanto tempo impiegate per eseguire il seguente codice
     - per 10000 volte
        - genera n, numero casuale tra 0 e 999
        - verifica se n è presente nell'insieme ordinato ssi (quindi ssi.find...). Non dovete stampare nulla

Infine, stampare i tre tempi in secondi

Opzionale: stampare il numero di ricerche/secondo.
           stampare i tempi di costruzione dei singoli elementi (vettore, lista, sortedset)
            (cioè quanto tempo impiegate a inserire i dati nella struttura dati)
 * */

long getNowInMicroSeconds()
{
    return DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000);
}

int length = 1000;
List<int> li = new List<int>();
SortedSet<int> ssi = new SortedSet<int>();
bool[] vb = new bool[length];
Random rand = new Random();

for (int i = 0; i < length; i++)
{
    if(vb[i] != true)
    {
        vb[i] = false;

    }
    int myRand = rand.Next(0, length);
    li.Add(myRand);
    ssi.Add(myRand);
    vb[myRand] = true;
}
//Console.WriteLine(String.Join(",",vb));
//Console.WriteLine(String.Join(",", li));
//Console.WriteLine(String.Join(",", ssi));
List<int> lcheck = new List<int>();
for (int i = 0; i < 10000; i++)
{
    lcheck.Add(rand.Next(0, length));
}

long start;
long end;

start = getNowInMicroSeconds();
int trovatiVettore = 0;
int nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);

start = getNowInMicroSeconds();
int trovatiLista = 0;
int nonTrovatiLista = 0;
for (int i = 0; i < 10000; i++)
{
    if (li.Contains(lcheck[i]))
        trovatiLista++;
    else
        nonTrovatiLista++;
}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiLista);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiLista);

start = getNowInMicroSeconds();
int trovatiInSortedSet = 0;
int nonTrovatiInSortedSet = 0;
for (int i = 0; i < 10000; i++)
{
    if (ssi.Contains(lcheck[i]))
        trovatiInSortedSet++;
    else
        nonTrovatiInSortedSet++;
}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in ssi si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in ssi si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiInSortedSet);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiInSortedSet);

start = getNowInMicroSeconds();
trovatiVettore = 0;
nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);


start = getNowInMicroSeconds();
trovatiVettore = 0;
nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);

start = getNowInMicroSeconds();
trovatiLista = 0;
nonTrovatiLista = 0;
for (int i = 0; i < 10000; i++)
{
    if (li.Contains(lcheck[i]))
        trovatiLista++;
    else
        nonTrovatiLista++;
}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiLista);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiLista);

start = getNowInMicroSeconds();
trovatiVettore = 0;
nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);


start = getNowInMicroSeconds();
trovatiVettore = 0;
nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);


start = getNowInMicroSeconds();
trovatiVettore = 0;
nonTrovatiVettore = 0;
for (int i = 0; i < 10000; i++)
{
    if (vb[lcheck[i]])
        trovatiVettore++;
    else
        nonTrovatiVettore++;

}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in vb si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiVettore);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiVettore);


start = getNowInMicroSeconds();
trovatiLista = 0;
nonTrovatiLista = 0;
for (int i = 0; i < 10000; i++)
{
    if (li.Contains(lcheck[i]))
        trovatiLista++;
    else
        nonTrovatiLista++;
}
end = getNowInMicroSeconds();
Console.WriteLine("\n10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}micros", end - start);
Console.WriteLine("10000 numeri compresi tra 1 e 999  e controllarli in li si impiega: {0}s", (double)(end - start) / 1000000000);
Console.WriteLine("Numero di ricerche al secondo = {0}", (long)10000 * 1000 * 1000000000 / (end - start));
Console.WriteLine("Risultati trovati: {0}", trovatiLista);
Console.WriteLine("Risultati NON trovati: {0}", nonTrovatiLista);