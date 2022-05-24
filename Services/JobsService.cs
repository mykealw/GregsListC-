

using GregsList.FakeDB;
using GregsList.Models;

namespace GregsList.Services
{
    public class JobsService
    {
        internal List<Job> GetAllJobs()
        {
            return Database.Jobs;
        }
    }
}