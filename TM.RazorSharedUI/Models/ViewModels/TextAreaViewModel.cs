using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.RazorSharedUI.Constants;
using TM.RazorSharedUI.Models.Interfaces;

namespace TM.RazorSharedUI.Models.ViewModels
{
  public class TextAreaViewModel : BaseElementViewModel, IInputElement
  {
    public bool IsCompact { get; set; } = false;
    public string? Value { get; set; }
    public string? InputContainerClassName { get; set; }
    public string? InputClassName { get; set; }

    public override string GetPartialViewPath() => Routes.Inputs.TEXTBOX;
  }
}
