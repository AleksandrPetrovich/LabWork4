using Microsoft.VisualStudio.TestTools.UnitTesting;
using Port.Model;

namespace UnitTests
{
    [TestClass]
    public class UTPort
    {
        [TestMethod]
        public void TestUnload()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);
            Ship ship = new Ship("Ship", port);
            port.Unload(ship);
            Assert.IsTrue(port.InPort.Contains(ship));           
        }

        [TestMethod]
        public void TestShipArrives()
        {
            Port.Model.Port port1 = new Port.Model.Port("Port1", 1000);
            Port.Model.Port port2 = new Port.Model.Port("Port2", 2000);
            Ship ship = new Ship("Ship", port1);
            port2.ShipArrives(ship);
            Assert.IsTrue(port2.InPort.Contains(ship));
        }

        [TestMethod]
        public void TestShipDepartures()
        {
            Port.Model.Port port = new Port.Model.Port("Port", 1000);           
            Ship ship = new Ship("Ship", port);            
            port.ShipDepartures(ship);
            Assert.IsFalse(port.InPort.Contains(ship));
        }
    }
}
