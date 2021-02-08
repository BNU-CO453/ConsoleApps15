using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ConsoleAppProject.Helpers
{
    public enum MyEnum
    {
        [Display(Name = "First Value")]
        [Description("This is the First Value")]
        FirstValue = 2,
        
        [Description("This is the Second Value")]
        [Display(Name = "Second Value")]
        SecondValue = 4,
        
        [Description("This is the Third Value")]
        [Display(Name = "Third Value")]
        ThirdValue = 6
    }
}
