namespace ImplicitExplicit
{
    internal class Kilogram
    {
        private float Weight { get; set; }
 
        public Kilogram(float weight)
        {
            Weight = weight;
        }
 
        public override string ToString()
        {
            return $"{Weight} kg";
        }
    }
}