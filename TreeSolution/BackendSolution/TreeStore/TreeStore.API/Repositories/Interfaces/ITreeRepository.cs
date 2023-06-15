using TreeStore.API.Models;

namespace TreeStore.API.Repositories.Interfaces
{
    public interface ITreeRepository
    {
        public List<Tree> GetChildNodes(int nodeId);
        public List<Tree> GetRootNodes();
    }
}
