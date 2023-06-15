using TreeStore.API.Models;

namespace TreeStore.API.Services.Interfaces
{
    public interface ITreeService
    {
        public List<Tree> GetChildNodes(int id);

        public List<Tree> GetRootNodes();
    }
}
