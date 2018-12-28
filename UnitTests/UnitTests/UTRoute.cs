using Microsoft.VisualStudio.TestTools.UnitTesting;
using Port.Model;

namespace UnitTests
{
    [TestClass]
    public class UTRoute
    {
        [TestMethod]
        public void TestCost()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Route route = new Route(port1);
            route.SetDeparture(port2);
            Fuel fuel = new Fuel(45);
            route.Cost(fuel);
            Assert.AreEqual(45000, route.Costs);
        }

        [TestMethod]
        public void TestWay()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Route route = new Route(port1);
            route.SetDeparture(port2);
            Assert.AreEqual(1000, route.Way());
        }

        [TestMethod]
        public void TestSetDeparture()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Route route = new Route(port1);
            route.SetDeparture(port2);
            Assert.AreEqual(port2, route.Departure);
        }

        [TestMethod]
        public void TestSum()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);            
            Route route = new Route(port);
            route.Sum(123456);
            Assert.AreEqual(123456, route.Sums);
        }
    }
}
