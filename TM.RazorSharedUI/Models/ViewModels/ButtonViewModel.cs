using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM.RazorSharedUI.Constants;

namespace TM.RazorSharedUI.Models.ViewModels
{
  public class ButtonViewModel : BaseElementViewModel
  {
    public override string GetPartialViewPath() => Routes.Inputs.BUTTON;
    public string? InputClassName { get; set; }
    public string? OnClickJavascript { get; set; }
  }
}
