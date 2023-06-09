﻿using Shop.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Interfaces
{
    public interface ICommentBusiness
    {
        long GetTotalByIDProduct(long idProduct);
        IEnumerable<CommentDTO> SelectByIDProduct(long idProduct, int page, int pageSize);
        CommentDTO GetCommentByIDAccount(long IDAccount, long IDProduct);
        void Insert(CommentDTO commentDTO);
        void DeleteByIDAccount(long IDAccount);
        void DeleteByIDProduct(long IDProduct, bool where = false);
        void DeleteComment(long id);
        long GetTotal();
        IEnumerable<CommentDTO> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<CommentDTO> SelectAll();
    }
}
