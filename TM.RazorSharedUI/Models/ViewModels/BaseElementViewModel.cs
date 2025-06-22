﻿using TM.RazorSharedUI.Models.Interfaces;

namespace TM.RazorSharedUI.Models.ViewModels
{
	public abstract class BaseElementViewModel : IRenderableElement
	{
		/// <summary>
		/// CRUD Name; Add/Create, Fetch/Read, Edit/Update, Remove/Delete
		/// </summary>
		public string OperationName { get; set; } = "add";
		public string IdName { get; set; }
		public string Title { get; set; }
		public string? ClassName { get; set; }
		public bool IsLabelVisible { get; set; } = true;
		public string? AspName { get; set; } = "";

    public virtual string Id => $"txt-{OperationName}-{IdName}";
		public virtual string Name => string.IsNullOrEmpty(AspName) ? $"txt_{OperationName}_{IdName}" : AspName;
		public virtual string PlaceHolder => $"Enter {Title}";
		public string NotifId => $"notif-{OperationName}-{IdName}";

		public abstract string GetPartialViewPath();
	}
}
