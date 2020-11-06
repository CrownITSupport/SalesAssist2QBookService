using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SA2QBookSvc.DataAccessQuickBooks.Tests {
    [TestClass]
    public class RepositoryTests {
        protected Repository _qbRepo = new Repository();
        [TestMethod]
        public void OpenConnection() {
            // Arrange
            // Act
            var qbSession = _qbRepo.OpenConnection();
            var msgSet = qbSession.CreateMsgSetRequest("US",13,0);
            var objectToAdd = msgSet.AppendCurrencyQueryRq();
            // Assert
        }
    }
}
