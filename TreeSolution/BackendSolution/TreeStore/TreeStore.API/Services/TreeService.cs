using TreeStore.API.Models;
using TreeStore.API.Repositories.Interfaces;
using TreeStore.API.Services.Interfaces;

namespace TreeStore.API.Services
{
    public class TreeService: ITreeService
    {
        private ITreeRepository _treeRepository;

        public TreeService(ITreeRepository treeRepository)
        {
            _treeRepository = treeRepository;
        }

        public List<Tree> GetChildNodes(int id)
        {
            return _treeRepository.GetChildNodes(id);
        }

        public List<Tree> GetRootNodes()
        {
            return _treeRepository.GetRootNodes();
        }
    }
}
