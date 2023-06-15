using System.Collections.Generic;
using TreeStore.API.Models;
using TreeStore.API.Repositories.Interfaces;

namespace TreeStore.API.Repositories
{
    public class TreeRepository : ITreeRepository
    {
        private List<Tree> root { get; set; } = new();

        public TreeRepository()
        {
            Tree child1 = new Tree(1, "Child 1", null);
            Tree child2 = new Tree(2, "Child 2", null);

            Tree child11 = new Tree(3, "Child 1.1", "Owner 1.1");
            Tree child12 = new Tree(4, "Child 1.2", "Owner 1.2");
            Tree child21 = new Tree(5, "Child 2.1", "Owner 2.1");
            Tree child22 = new Tree(6, "Child 2.2", "Owner 2.2");
            Tree child23 = new Tree(7, "Child 2.2", "Owner 2.2");

            Tree child111 = new Tree(8, "Child 1.1.1", "Owner 1.1.1");
            Tree child112 = new Tree(9, "Child 1.1.2", "Owner 1.1.2");
            Tree child221 = new Tree(10, "Child 2.2.1", "Owner 2.2.1");
            Tree child222 = new Tree(11, "Child 2.2.2", "Owner 2.2.2");

            Tree child1121 = new Tree(12, "Child 1.1.2.1", "Owner 1.1.2.1");

            child111.Steps.Add(new StepModel { TreeId = child1121.TreeId, TreeName = child1121.TreeName, Owner = child1121.Owner });
            child11.Steps.Add(new StepModel { TreeId = child111.TreeId, TreeName = child111.TreeName, Owner = child111.Owner });
            child11.Steps.Add(new StepModel { TreeId = child112.TreeId, TreeName = child112.TreeName, Owner = child112.Owner });
            child22.Steps.Add(new StepModel { TreeId = child221.TreeId, TreeName = child221.TreeName, Owner = child221.Owner });
            child22.Steps.Add(new StepModel { TreeId = child222.TreeId, TreeName = child222.TreeName, Owner = child222.Owner });
            child1.Steps.AddRange(new List<StepModel> { new StepModel { TreeId = child11.TreeId, TreeName = child11.TreeName, Owner = child11.Owner },
                                  new StepModel { TreeId = child12.TreeId, TreeName = child12.TreeName, Owner = child12.Owner }});
            child2.Steps.AddRange(new List<StepModel> { new StepModel { TreeId = child21.TreeId, TreeName = child21.TreeName, Owner = child21.Owner },
                                  new StepModel { TreeId = child22.TreeId, TreeName = child22.TreeName, Owner = child22.Owner },
                                  new StepModel { TreeId = child23.TreeId, TreeName = child23.TreeName, Owner = child23.Owner }});
            root.AddRange(new List<Tree> { child1, child2, child11, child12, child21, child22, child111 });
        }

        public List<Tree> GetChildNodes(int nodeId)
        {
            return root.Where(n => n.TreeId == nodeId).ToList();
        }

        public List<Tree> GetRootNodes()
        {
            var res = root.Where(n => n.Owner == null).ToList();
            var reducedList = res.Select(e => new Tree(e.TreeId, e.TreeName, null)).ToList();
            return reducedList;
        }
    }
};

