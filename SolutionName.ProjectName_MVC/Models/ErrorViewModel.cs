using System;

namespace SolutionName.ProjectName_MVC.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string AnimalName { get; set; }
        public int AnimalWeight { get; set; }
    }
}
