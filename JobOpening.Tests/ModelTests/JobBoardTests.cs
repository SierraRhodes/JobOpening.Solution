using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobOpening.Models;

namespace JobOpening.Tests
{
  [TestClass]
  public class JobBoardTests
  { 
   [TestMethod]
   public void PostJob_JobPostToBoard_ViewJob()
   {
    JobBoard testJobBoard = new JobBoard();
    Job testJob = new Job("Software Engineer", "Fixing Bugs", "Email");

    testJobBoard.PostJob(testJob);
    Job retrievedJob = testJobBoard.Jobs[0];

    Assert.AreEqual(testJob.Title, retrievedJob.Title);
    Assert.AreEqual(testJob.Description, retrievedJob.Description);
    Assert.AreEqual(testJob.ContactInfo, retrievedJob.ContactInfo);
    Assert.AreEqual(1, testJobBoard.Jobs.Count);
    

   }
  }
}