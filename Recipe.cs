namespace HACKATHON
{
    partial class Program
    {
        class Recipe {
            private string Name;
            private int ProwessCost;
            private string Description;
            private string Ascii;
            public Recipe(string name, int cost, string descrip, string ascii) {
                Name = name;
                ProwessCost = cost;
                Description = descrip;
                Ascii = ascii;
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
            public string ASCII{
                get {
                    return Ascii;
                }
            }
        }
    }
}
