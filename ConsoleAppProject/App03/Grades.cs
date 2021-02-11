using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Display(Name = "Fail")]
        [Description("Referred")]
        F,
        [Display(Name = "III")]
        [Description("BSc(Hons) Third Class")]
        D,
        [Display(Name = "II-2")]
        [Description("BSc(Hons) Lower Second")]
        C,
        [Display(Name = "II-1")]
        [Description("BSc(Hons) Upper Second")]
        B,
        [Display(Name = "1st")]
        [Description("BSc(Hons) First Class")]
        A
    }
}
