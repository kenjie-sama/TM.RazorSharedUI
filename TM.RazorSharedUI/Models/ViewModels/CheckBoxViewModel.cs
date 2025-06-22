
using TM.RazorSharedUI.Constants;

namespace TM.RazorSharedUI.Models.ViewModels
{
	public class CheckBoxViewModel : BaseElementViewModel
	{
		public override string GetPartialViewPath() => Routes.Inputs.CHECKBOX;

		public bool IsChecked { get; set; }
	}
}
