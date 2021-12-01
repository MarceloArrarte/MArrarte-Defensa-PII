namespace Ucu.Poo.Defense
{
    public class ResidueType
    {
        public string Name { get; set; }

        public bool IsOrganic { get; set; }

        public ResidueType(string name, bool isOrganic)
        {
            this.Name = name;
            this.IsOrganic = isOrganic;
        }
    }
}