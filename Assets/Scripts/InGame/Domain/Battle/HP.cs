using System;
public class HP
{
    const int min = 0;
    const int max = 999;

    public readonly int value;

    public HP(int value){
        if(value < min) throw new ArgumentOutOfRangeException();
        if(value > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }

    public HP Minus(Damage damage){
        int result = value - damage.value;
        result = Math.Max(result, min);
        return new HP(result);
    }
}