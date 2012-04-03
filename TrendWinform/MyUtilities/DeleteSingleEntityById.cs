using System;
using NHibernate;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    internal class DeleteSingleEntityById
    {
        public static void DeleteActiveUserFileById(Guid aufId)
        {
            ActiveUserFile auf;
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
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
