namespace DesignPatterns.Core.PrototypePattern
{
    public class Prototype
    {
        public Prototype(int intvValue, double doubleValue)
        {
            IntValueProperty = intvValue;
            DoubleValueProperty = doubleValue;
        }
        
        public int IntValueProperty { get; set; }
        
        public double DoubleValueProperty { get; set; }

        public Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }
}