// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of MarkNotificationAsDone
	/// </summary>
	public class MarkNotificationAsDonePayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// Did the operation succeed?
		/// </summary>
		public bool? Success { get; set; }

		/// <summary>
		/// The user that the notification belongs to.
		/// </summary>
		public User Viewer { get; set; }
	}
}
