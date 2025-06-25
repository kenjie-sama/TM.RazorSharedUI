using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.RazorSharedUI.Constants
{
  public abstract class Routes
  {
    public static class Inputs
    {
      public const string DATE = @"../Shared/Inputs/_DateFieldPartial";
      public const string TEXTBOX = @"../Shared/Inputs/_InputFieldPartial";
      public const string CHECKBOX = @"../Shared/Inputs/_CheckBoxPartial";
      public const string SELECT = @"../Shared/Inputs/_SelectPartial";
      public const string RADIO_GROUP = @"../Shared/Inputs/_RadioGroupPartial";
    }
  }
}
