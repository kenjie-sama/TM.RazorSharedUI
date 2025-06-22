
using TM.RazorSharedUI.Models.Dtos;

namespace TM.RazorSharedUI.Models.ViewModels
{
  public class DropdownOptionViewModel : DropdownOptionDto
  {
    public static DropdownOptionViewModel Default(string Label) => new()
    {
      Value = "",
      Label = Label
		};

    public static List<DropdownOptionViewModel> InitOptions(string defaultLabel, IEnumerable<DropdownOptionViewModel> options) {

      List<DropdownOptionViewModel> opts = [Default(defaultLabel)];
      opts.AddRange(options);

      return opts;
    }
  }
}
