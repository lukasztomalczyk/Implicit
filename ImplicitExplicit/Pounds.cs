namespace ImplicitExplicit
{
    internal class Pounds
    {
        public float Weight { get; set; }
 
        public Pounds(float weight)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Weight} lbs";
        }
 
        public static implicit operator Kilogram(Pounds lbs)
        {
            const float conversionRate = 0.45359237f;
 
            float equivalentKgs = lbs.Weight * conversionRate;
 
            return new Kilogram(equivalentKgs);
        }
    }
}