﻿namespace TGServerService.ChatCommands
{
	/// <summary>
	/// Metadata about the currently running <see cref="ChatCommand"/>
	/// </summary>
	sealed class CommandInfo
	{
		/// <summary>
		/// If the <see cref="ChatCommand"/> was invoked by an admin
		/// </summary>
		public bool IsAdmin { get; set; }
		/// <summary>
		/// If the <see cref="ChatCommand"/> was invoked from an admin chat channel
		/// </summary>
		public bool IsAdminChannel { get; set; }
		/// <summary>
		/// The name of the <see cref="ChatCommand"/> invoker
		/// </summary>
		public string Speaker { get; set; }
		/// <summary>
		/// A reference to the <see cref="ServerInstance"/> that runs the <see cref="ChatProviders.IChatProvider"/> that heard the <see cref="ChatCommand"/>
		/// </summary>
		public ServerInstance Server { get; set; }
	}
}
