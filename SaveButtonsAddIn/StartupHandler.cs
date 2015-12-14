using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace SaveButtonsAddIn
{
	public class StartupHandler : CommandHandler
	{
		protected override void Run()
		{
			IdeApp.Workbench.ShowCommandBar ("MyCommandsBar");
		}
	}
}

