// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of RemoveReaction
	/// </summary>
	public class RemoveReactionInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the subject to modify.
		/// </summary>
		public ID SubjectId { get; set; }

		/// <summary>
		/// The name of the emoji reaction to remove.
		/// </summary>
		public ReactionContent Content { get; set; }
	}
}
