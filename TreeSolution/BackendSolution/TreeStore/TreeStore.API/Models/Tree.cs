using System.Xml.Linq;

namespace TreeStore.API.Models
{
    public class Tree
    {
        public int TreeId { get; set; }
        public string TreeName { get; set; }

        public string Owner { get; set; }

        public List<StepModel> Steps { get; set; } = new();

        public Tree(int id, string name, string owner)
        {
            TreeId = id;
            TreeName = name;
            Owner = owner;
        }

    }
}
