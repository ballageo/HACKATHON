namespace HACKATHON
{
    partial class Program
    {
        class Utensil {
            private string Name;
            private int ProwessCost;
            private int ProwessBoost;
            private string Description;
            public Utensil(string name, int cost, int boost, string descrip) {
                Name = name;
                ProwessCost = cost;
                ProwessBoost = boost;
                Description = descrip;
            }
            public int Cost {
                get {
                    return ProwessCost;
                }
            }
            public int Boost {
                get {
                    return ProwessBoost;
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