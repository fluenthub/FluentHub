// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of ClosePullRequest
	/// </summary>
	public class ClosePullRequestInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// ID of the pull request to be closed.
		/// </summary>
		public ID PullRequestId { get; set; }
	}
}
