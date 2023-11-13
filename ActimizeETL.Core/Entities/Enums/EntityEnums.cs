
using System.ComponentModel.DataAnnotations;

namespace ActimizeETL.Core.Entities.Enums
{
    public enum Sources
    {
        [Display(Name = "Automated Clearing House")] ACH =1,
        [Display(Name = "SWIFT")] SWIFT =2,
        [Display(Name = "Wire Transfers")] WF =3
    }
    public enum Destinations
    {
        [Display(Name ="Watch List Filtering")] WLF =1,
        [Display(Name = "Suspicious Activity Monitoring")] SAM = 2,
        [Display(Name = "Customer Due Diligence")] CDD = 3,
    }

    public enum ProcessStatus
    {
        [Display(Name = "SUCCESSFUL")] SUCCESSFUL = 1,
        [Display(Name = "PENDING")] PENDING = 2,
    }
}
