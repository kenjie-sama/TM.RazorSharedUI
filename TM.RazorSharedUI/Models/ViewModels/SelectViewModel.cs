using TM.RazorSharedUI.Constants;
using TM.RazorSharedUI.Models.Interfaces;

namespace TM.RazorSharedUI.Models.ViewModels
{
	public class SelectViewModel : BaseElementViewModel, IInputElement
	{
		public IEnumerable<DropdownOptionViewModel> Options { get; set; }

		public override string PlaceHolder => $"Select {Title}" ;

		public override string Id => $"sel-{OperationName}-{IdName}";
		public override string Name => $"sel_{OperationName}_{IdName}";

    public string? InputContainerClassName { get; set; }
    public string? InputClassName { get; set; }

    public override string GetPartialViewPath() => Routes.Inputs.SELECT;
	}
}
