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
// Cake;- requires 10 prowess; when baked = gain req/2; if failed to bake = prowess - req/2; if failedToLearn = prowess - req/10;
// Cheesecake; - requires 50 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Tiramisu; requires 500 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// BakedAlaska; requires 1000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Stripper Cake; requires 5000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;