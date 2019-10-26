using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class ManufacturingCompany
    {
        private readonly IFactory _factory;
        private readonly List<IComputer> _computers;
        private readonly List<ITablet> _tablets;
        private readonly List<ISmartPhone> _SmartPhone;

        public IEnumerable<IComputer> Computers { get { return _computers.ToArray(); } }
        public IEnumerable<ITablet> Tablets { get { return _tablets.ToArray(); } }
        public IEnumerable<ISmartPhone> SmartPhones { get { return _SmartPhone.ToArray(); } }

        public ManufacturingCompany(IFactory factory)
        {
            _factory = factory;
            _computers = new List<IComputer>();
            _tablets = new List<ITablet>();
            _SmartPhone = new List<ISmartPhone>();
        }

        public void Produce(Orders orders)
        {
            MakeComputers(orders.Computers);
            MakeTablets(orders.SmartPhone);
            MakeSmartPhones(orders.Tablet);
        }

        private void MakeComputers(int count)
        {
            while(_computers.Count < count)
            {
                _computers.Add(_factory.MakeComputer());
            }
        }

        private void MakeTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(_factory.MakeTablet());
            }
        }

        private void MakeSmartPhones(int count)
        {
            while (_SmartPhone.Count < count)
            {
                _SmartPhone.Add(_factory.MakeSmartPhone());
            }
        }
    }
}
