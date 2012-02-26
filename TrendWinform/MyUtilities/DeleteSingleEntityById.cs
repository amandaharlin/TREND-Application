using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    class DeleteSingleEntityById
    {
        public static void DeleteActiveUserFileById(Guid aufId)
        {
            ActiveUserFile auf;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    auf = session.Get<ActiveUserFile>(aufId);
                    if (auf != null)
                    {
                        session.Delete(auf);
                    }
                    transaction.Commit();
                }
            }
            
        }
    }
}
