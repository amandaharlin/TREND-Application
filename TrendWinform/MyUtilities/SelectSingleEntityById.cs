using System;
using NHibernate;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    internal class SelectSingleEntityById
    {
        public static Firm SelectFirmById(Guid firmId)
        {
            Firm firm;

            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    firm = session.Get<Firm>(firmId);
                    transaction.Commit();
                }
            }


            return firm;
        }

        public static FirmContact SelectFirmContactById(Guid requesterId)
        {
            FirmContact firmContact;
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    firmContact = session.Get<FirmContact>(requesterId);
                    transaction.Commit();
                }
            }

            return firmContact;
        }

        public static Employee SelectEmployeeById(Guid employeeId)
        {
            Employee employee;
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    employee = session.Get<Employee>(employeeId);
                    transaction.Commit();
                }
            }


            return employee;
        }


        public static ActiveUserFile SelectActiveUserFileById(Guid aufId)
        {
            ActiveUserFile auf;
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    auf = session.Get<ActiveUserFile>(aufId);
                    transaction.Commit();
                }
            }
            return auf;
        }
    }
}
