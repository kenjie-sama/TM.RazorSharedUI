﻿using System.Diagnostics.CodeAnalysis;

namespace TM.Constants
{
  public sealed class RegEx
  {
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string SERIALNUMBER = @"[A-Z0-9\-]{6,}";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string NAMES = @"^[\p{L}\s_.,ñÑ]+$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string USERNAME = @"^[\p{L}0-9_.]+$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string PHONE = @"^\d+$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string EMAIL_LOCAL = @"^[a-zA-Z0-9._%+-]+(?=@)";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string EMAIL_STRICT = @"^[\w\.\-]+@[\w\-]+(\.[\w\-]+)*\.[a-zA-Z]{2,}$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string COMMON = @"^[\p{L}\p{N} .,""'\-_/]+$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string CONTACT_NUMBER = @"^\+?[\d\s\-()]{7,20}$";
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string NON_EMPTY_WHITESPACE = @"(.|\s)*\S(.|\s)*";

  }
}
