using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses
{
    public enum eAnalysisDataBasis
    {
        Combined = 0,
        Status = Post.eType.status,
        Photo = Post.eType.photo,
        Video = Post.eType.video
    }
}
