using Microsoft.VisualStudio.TestTools.UnitTesting;
using Port.Model;

namespace UnitTests
{
    [TestClass]
    public class UTShip
    {
        [TestMethod]
        public void TestSend()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Route route = new Route(port2);            
            Fuel fuel = new Fuel(45);
            Ship ship = new Ship("Ship", port1);
            ship.SetRoute(route);
            ship.Fill(fuel);
            ship.Send();
            Assert.AreEqual(port2, ship.Port);
        }

        [TestMethod]
        public void TestLoad()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);
            Ship ship = new Ship("Ship", port);
            var cargo = new Cargo(100000);
            ship.Load(cargo);
            Assert.IsTrue(ship.Cargos.Contains(cargo));
        }

        [TestMethod]
        public void TestUnload()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);
            Ship ship = new Ship("Ship", port);
            var cargo = new Cargo(100000);
            ship.Load(cargo);
            ship.Unload();
            Assert.IsTrue(ship.Cargos.Count==0);
        }

        [TestMethod]
        public void TestSetRoute()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Ship ship = new Ship("Ship", port1);
            Route route = new Route(port2);
            ship.SetRoute(route);
            Assert.AreEqual(route, ship.Route);
        }

        [TestMethod]
        public void TestRemoveRoute()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Ship ship = new Ship("Ship", port1);
            Route route = new Route(port2);
            ship.SetRoute(route);
            ship.RemoveRoute();
            Assert.IsNull(ship.Route);
        }

        [TestMethod]
        public void TestFill()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);
            Ship ship = new Ship("Ship", port);
            Fuel fuel = new Fuel(45);
            ship.Fill(fuel);
            Assert.AreEqual(fuel, ship.Fuel);
        }

        [TestMethod]
        public void TestReady()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Ship ship = new Ship("Ship", port1);
            Fuel fuel = new Fuel(45);
            ship.Fill(fuel);
            Route route = new Route(port2);
            ship.SetRoute(route);            
            Assert.IsTrue(ship.Ready());
        }
    }
}
