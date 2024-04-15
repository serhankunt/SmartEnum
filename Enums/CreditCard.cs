using Ardalis.SmartEnum;
using SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnum.Enums;
public enum CreditCard
{
    Standard,
    Platinium,
    Premium
}

public sealed class CreditCard2 : SmartEnum<CreditCard2>
{
    public static readonly CreditCard2 Standard = new("Standart", 0);
    public static readonly CreditCard2 Platinium = new("Platinum", 1);
    public static readonly CreditCard2 Premium = new("Premium", 2);

    public CreditCard2(string name, int value) : base(name, value)
    {

    }

    public double GetDiscountRate()
    {
        return this switch
        {
            var cc when cc == Standard => 0.01,
            var cc when cc == Platinium => 0.1,
            var cc when cc == Premium => 0.2,
            _ => throw new NotImplementedException()    
        };
    }
}

public sealed class CreditCard3 : Enumeration<CreditCard3>
{
    public static readonly CreditCard3 Standard = new(1, nameof(Standard));
    public static readonly CreditCard3 Platinum = new(2, nameof(Platinum));
    public static readonly CreditCard3 Premium = new(3, nameof(Premium));

    public CreditCard3(int value, string name) : base(value, name)
    {
    }
}