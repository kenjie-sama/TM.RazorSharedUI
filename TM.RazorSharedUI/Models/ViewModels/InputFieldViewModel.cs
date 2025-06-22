using TM.RazorSharedUI.Constants;
using TM.RazorSharedUI.Enums;
using TM.RazorSharedUI.Models.Interfaces;

namespace TM.RazorSharedUI.Models.ViewModels
{
	public class InputFieldViewModel : BaseElementViewModel, IInputElement
	{
		public bool IsCompact { get; set; } = false;
		public bool IsDisabled { get; set; } = false;

		public string? Value { get; set; }
    public InputType? Type { get; set; } = InputType.Text;
    public string? InputContainerClassName { get; set; }
    public string? InputClassName { get; set; }

    public override string GetPartialViewPath() => Routes.Inputs.TEXTBOX;
	}
}
