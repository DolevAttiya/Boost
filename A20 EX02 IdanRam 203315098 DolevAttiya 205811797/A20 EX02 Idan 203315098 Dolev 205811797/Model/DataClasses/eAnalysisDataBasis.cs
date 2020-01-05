using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public enum eAnalysisDataBasis
    {
        Combined = 0,
        Status = Post.eType.status,
        Photos = Post.eType.photo,
        Videos = Post.eType.video
    }
}
