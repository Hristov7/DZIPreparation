namespace ArtefactSystem
{
    public abstract class Artifact
    {
        protected Artifact(string typeArtifact, double acquisitionPrice)
        {
            this.typeArtifact = typeArtifact;
            this.acquisitionPrice = acquisitionPrice;
        }
        private string _typeArtifact;
        private double _acquisitionPrice;
        public string typeArtifact
        {
            get { return _typeArtifact; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Can't be empty");
                }
                _typeArtifact = value;
            }
        }
        public double acquisitionPrice
        {
            get { return _acquisitionPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be negative");
                }
                _acquisitionPrice = value;
            }
        }

        public abstract double PriceForVisitor();
    }
}
