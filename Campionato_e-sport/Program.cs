
int n_kill, n_eliminazioni, n_obbiettivi, tot_kill = 0, tot_eliminazioni = 0, tot_obbiettivi = 0, diff_eliminazioni = 0, n_vittorie = 0, n_pareggi = 0, n_sconfitte = 0, punti = 0, percentuale_vitt, triplo_obb = 0, no_eliminazioni = 0, max_kill=0, max_kill_match=0, i;

for (i = 0; i < 10; i++)
{
    Console.WriteLine("Inserire il numero di kill del match n." + (i+1));
    n_kill = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserire il numero di eliminazioni subite del match n." + (i+1));
    n_eliminazioni = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserire il numero di obbiettivi conquistati del match n." + (i+1));
    n_obbiettivi = Convert.ToInt32(Console.ReadLine());

    if(n_kill < 0||n_eliminazioni<0||n_obbiettivi<0)
    {
        Console.WriteLine("Errore: Kill eliminazioni ed obbiettivi devono essere almeno 0");
        i--;
    }
    else
    {
        if(n_kill > n_eliminazioni)
        {
            n_vittorie++;
            punti = punti + 3;
        }
        else if (n_kill == n_eliminazioni)
        {
            n_pareggi++;
            punti = punti + 1;
        }
        else if (n_kill < n_eliminazioni)
        {
            n_sconfitte++;
        }

        if(n_obbiettivi>=3)
        {
            triplo_obb++;
        }

        if(n_eliminazioni==0)
        {
            no_eliminazioni++;
        }

        tot_kill = tot_kill + n_kill;
        tot_eliminazioni=tot_eliminazioni + n_eliminazioni;
        tot_obbiettivi=tot_obbiettivi + n_obbiettivi;

        if(i==0)
        {
            max_kill_match = 1;
            max_kill = n_kill;
        }
        else if(n_kill>max_kill)
        {
            max_kill_match = i + 1;
            max_kill = n_kill;
        }
    }

}



diff_eliminazioni = tot_kill - tot_eliminazioni;
percentuale_vitt = n_vittorie * 10;

if (punti >= 24)
{
    Console.WriteLine("Squadra dominante\n");
}
else if (punti >= 18)
{
    Console.WriteLine("Squadra competitiva\n");
}
else if (punti >= 12)
{
    Console.WriteLine("Buona squadra\n");
}
else if (punti < 12)
{
    Console.WriteLine("Necessario migliorare\n");
}

Console.WriteLine("Sono state vinte " + n_vittorie + " partite \n");
Console.WriteLine("Sono stati fatti " + n_pareggi + " pareggi\n");
Console.WriteLine("Sono state perse " + n_sconfitte + " partite \n");

Console.WriteLine("Per un totale di " + punti + " punti\n");

Console.WriteLine("Sono state fatte " + tot_kill + " kill \n");
Console.WriteLine("Sono state subite " + tot_eliminazioni + " eliminazioni\n");
Console.WriteLine("Sono stati conquistati " + tot_obbiettivi + " obbiettivi\n");
Console.WriteLine("La differenza tra kill ed eliminazioni è " + diff_eliminazioni + "\n");

Console.WriteLine("In percentuale le vittorie sono state il " + percentuale_vitt + "%\n");
Console.WriteLine("In " + triplo_obb + " partite la squadra ha conquistato almeno 3 obbiettivi\n");
Console.WriteLine("In " + no_eliminazioni + " partite la squadra non ha subito nessuna eliminazione\n");
Console.WriteLine("Il match con più kill è stato il n." + max_kill_match + " con " + max_kill + " \n");
