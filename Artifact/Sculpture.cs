namespace ArtefactSystem
{
    public class Sculpture : Artifact
    {
        private string _material;

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public Sculpture(string typeArtifact, double acquisitionPrice, string material) : base(typeArtifact, acquisitionPrice)
        {
            this.Material = material;
        }

        public override double PriceForVisitor()
        {
            if(this.Material == "bronze")
            return (this.acquisitionPrice * 1.10) + 10;

            return this.acquisitionPrice * 1.10;
        }

        public override string ToString()
        {
            return $"The sculpture costs {PriceForVisitor():f2} lv.";
        }
    }
}
