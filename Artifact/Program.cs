namespace ArtefactSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Artifact> artifacts = new();
            string input;
            while((input = Console.ReadLine())!= "END")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = parts[0];

                switch (type)
                {
                    case "painting":
                        artifacts.Add(new Painting(type, double.Parse(parts[1])));
                        break;
                    case "sculpture":
                        artifacts.Add(new Sculpture(type, double.Parse(parts[1]), parts[2]));
                        break;
                }
            }

            IOrderedEnumerable<IGrouping<string, Artifact>> groups = artifacts.GroupBy(a => a.typeArtifact).OrderBy(x => x.Key);

            foreach (IGrouping<string, Artifact> group in groups)
            {
                Console.WriteLine($"All {group.Key}:");
                foreach (Artifact item in group)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
/*
painting 500
sculpture 700 bronze
painting 300
sculpture 850 marble
painting 450
sculpture 600 bronze
END

*/