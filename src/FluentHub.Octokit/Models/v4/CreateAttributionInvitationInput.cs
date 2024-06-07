// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of CreateAttributionInvitation
	/// </summary>
	public class CreateAttributionInvitationInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the owner scoping the reattributable data.
		/// </summary>
		public ID OwnerId { get; set; }

		/// <summary>
		/// The Node ID of the account owning the data to reattribute.
		/// </summary>
		public ID SourceId { get; set; }

		/// <summary>
		/// The Node ID of the account which may claim the data.
		/// </summary>
		public ID TargetId { get; set; }
	}
}
