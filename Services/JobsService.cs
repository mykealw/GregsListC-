

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

        internal Job PostJob(Job jobData)
        {
            Database.Jobs.Add(jobData);
            return jobData;
        }

        internal void DeleteJob(string id)
        {
            Job found = GetJobById(id);
            Database.Jobs.Remove(found);
        }

        internal Job EditJob(Job jobData)
        {
            Job original = GetJobById(jobData.Id);
            original.Description = jobData.Description ?? original.Description;
            original.Type = jobData.Type ?? original.Type;
            original.Salary = jobData.Salary != 0 ? jobData.Salary : original.Salary;
            original.Title = jobData.Title ?? original.Title;
            original.ImgUrl = jobData.ImgUrl ?? original.ImgUrl;

            return original;
        }
    }
}