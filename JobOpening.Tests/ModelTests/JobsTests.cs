using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobOpening.Models;

namespace JobOpening.Tests
{
  [TestClass]
  public class JobTests
  {
   [TestMethod]
    public void Job_InstantiateJob_ReturnJob()
    {
      Job testJob = new Job("Software Engineer", "Fixing Bugs", "Email");

      Assert.AreEqual("Software Engineer", testJob.Title);
      Assert.AreEqual("Fixing Bugs", testJob.Description);
      Assert.AreEqual("Email", testJob.ContactInfo);
    }
  }
}