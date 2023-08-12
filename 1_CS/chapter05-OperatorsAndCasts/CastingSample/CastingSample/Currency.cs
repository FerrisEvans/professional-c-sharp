public readonly struct Currency
{
    public readonly uint Dollars;
    public readonly ushort Cents;
    public Currency(uint dollars, ushort cents) => (Dollars, Cents) = (dollars, cents);
    public override string ToString() => $"{Dollars}.{Cents,-2:00}";

    public static explicit operator Currency(float value)
    {
        checked
        {
            uint dollars = (uint)value;
            ushort cents = Convert.ToUInt16((value - dollars) * 100);
            return new Currency(dollars, cents);
        }
    }

    public static implicit operator float(Currency value) => value.Dollars + (value.Cents / 100.0f);
}