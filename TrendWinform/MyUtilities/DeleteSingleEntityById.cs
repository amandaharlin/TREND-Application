using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    class DeleteSingleEntityById
    {
        public static void DeleteComputerById(Guid compId)
        {
            Computer comp;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    comp = session.Get<Computer>(compId);
                    if (comp != null)
                    {
                        session.Delete(comp);
                    }
                    transaction.Commit();
                }
            }
        }

        public static void DeleteHardDriveById(Guid hdId)
        {
            HardDrive hd;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    hd = session.Get<HardDrive>(hdId);
                    if (hd != null)
                    {
                        session.Delete(hd);
                    }
                    transaction.Commit();
                }
            }
        }

        public static void DeleteForensicProcessById(Guid fpId)
        {
            ForensicProcess fp;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    fp = session.Get<ForensicProcess>(fpId);
                    if (fp != null)
                    {
                        session.Delete(fp);
                    }
                    transaction.Commit();
                }
            }
        }

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
