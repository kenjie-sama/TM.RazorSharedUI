
using TM.RazorSharedUI.Constants;

namespace TM.RazorSharedUI.Models.ViewModels
{
	public class RadioGroupViewModel : BaseElementViewModel
	{
		public string JavaScript { get; set; }
		public IEnumerable<RadioGroupButtonViewModel> RadioGroupButtons { get; set; }
		public override string Id => $"rd-grp-{OperationName}-{IdName}";
		public override string Name => $"rd_grp_{OperationName}_{IdName}";

		public override string GetPartialViewPath() => Routes.Inputs.RADIO_GROUP;
	}
}
