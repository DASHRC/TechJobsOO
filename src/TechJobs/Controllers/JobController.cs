using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.Models;
using TechJobs.ViewModels;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

   
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            // TODO #1 CHECK - get the Job with the given ID and pass it into the view
            Job requestedJob = jobData.Find(id); //stores Job object (peek definition of Find to see the method in the Job class
            return View(requestedJob);
        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

       

                jobData.Jobs.Add(newJob);
                return Redirect("/Job?id=" + newJob.ID);
            }

            return View(newJobViewModel);
        }
    }
}
