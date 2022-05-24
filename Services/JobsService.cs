

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

        internal Job GetJobById(string id)
        {
            Job job = Database.Jobs.Find(j => j.Id == id);
            if (job == null)
            {
                throw new Exception("Don't worry employment is high, bad Id");
            }
            return job;
        }
    }
}