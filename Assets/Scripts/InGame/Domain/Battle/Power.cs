using System;
public class Power
{
    const int min = 0;
    const int max = 999;

    public readonly int value;

    public Power(int value){
        if(value < min) throw new ArgumentOutOfRangeException();
        if(value > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }

    public Power Add(Power power){
        int added = this.value + power.value;
        added = Math.Min(added, max);
        return new Power(added);
    }
}