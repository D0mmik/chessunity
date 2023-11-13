using System;
using UnityEditor;
using UnityEngine;


public class Skript : MonoBehaviour
{
    public Vozidlo[] vozidla;

    void Start()
    {
        vozidla = new Vozidlo[] { new Auto(Color.cyan, "0"), new Tramvaj("2", 2) };
    }
}

public class Vozidlo
{
    public string id;
    
    public Vozidlo(string id)
    {
        this.id = id;
    }

    public virtual void Nabourej()
    {
        Debug.Log("Vozidlo nabouralo");
    }
}


[Serializable]
public class Auto : Vozidlo
{
    public string spz = "aaa";
    public Color barva;

    public Auto(Color barva ,string id) : base(id)
    {
        this.barva = barva;
    }
}

[Serializable]
public class Tramvaj : Vozidlo
{
    public int pocetKoleji;

    public Tramvaj(string id, int pocetKoleji) : base(id)
    {
        this.pocetKoleji = pocetKoleji;
    }

    public override void Nabourej()
    {
        base.Nabourej();
        Debug.Log("Tramvaj naboural"); 
    }
}

[Flags]
public enum TypAuta
{
    SUV,
    Sport,
    Pickup,
    Truck,
    Traktor,
    Hatchback,
    Cabriolet,
    Combi
}

public enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}