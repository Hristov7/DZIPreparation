namespace ArtefactSystem
{
    public class Painting : Artifact
    {
        public Painting(string typeArtifact, double acquisitionPrice) : base(typeArtifact, acquisitionPrice)
        {
        }

        public override double PriceForVisitor()
        {
            return this.acquisitionPrice * 1.25;
        }

        public override string ToString()
        {
            return $"The painting costs {PriceForVisitor():f2} lv.";
        }
    }
}
