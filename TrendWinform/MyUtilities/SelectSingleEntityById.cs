using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    class SelectSingleEntityById
    {
        public static Firm SelectFirmById(Guid firmId)
        {

            Firm firm;

            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
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
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    firmContact =  session.Get<FirmContact>(requesterId);
                    transaction.Commit();
                }
            }

            return firmContact;
        }

        public static Employee SelectEmployeeById(Guid employeeId)
        {
            Employee employee;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    employee =  session.Get<Employee>(employeeId);
                    transaction.Commit();
                }
            }


            return employee;
        }


        public static ActiveUserFile SelectActiveUserFileById(Guid aufId)
        {
            ActiveUserFile auf;
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    auf = session.Get<ActiveUserFile>(aufId);
                    transaction.Commit();
                }
            }
            return auf;
        }

    }
}
