namespace HACKATHON
{
    partial class Program
    {
        class Recipe {
            private string Name;
            private int ProwessCost;
            private string Description;
            public Recipe(string name, int cost, string descrip) {
                Name = name;
                ProwessCost = cost;
                Description = descrip;
            }
            public int Cost {
                get {
                    return ProwessCost;
                }
            }
            public string name {
                get {
                    return Name;
                }
            }
        }
    }
}