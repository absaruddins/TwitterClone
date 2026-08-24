using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    //interface formate holo always I dia likbo jamon ILikeable
    public interface ILikeable
    {
        bool CanBeLiked();
    }
}
