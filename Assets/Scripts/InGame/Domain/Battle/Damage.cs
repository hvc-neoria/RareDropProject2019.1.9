using System;
public class Damage
{
    const int min = 0;
    const int max = 99999;

    public readonly int value;

    public Damage(int value){
        if(value < min) throw new ArgumentOutOfRangeException();
        if(value > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }
}