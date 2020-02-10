using FacebookWrapper.ObjectModel;

namespace Boost.Model.DataClasses
{
    public enum eAnalysisDataBasis
    {
        Combined = 0,
        Status = Post.eType.status,
        Photos = Post.eType.photo,
        Videos = Post.eType.video
    }
}
