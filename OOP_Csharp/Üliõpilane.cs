using System;
using System.Collections.Generic;
using System.Text;

public class Üliõpilane : Õpilane 
{
    public string Eriala { get; set; }

    public override void Kirjelda()
    {
        base.Kirjelda();
        Console.WriteLine($"Eriala: {Eriala}");
    }
}
