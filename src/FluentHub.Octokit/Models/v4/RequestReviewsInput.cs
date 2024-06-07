// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of RequestReviews
	/// </summary>
	public class RequestReviewsInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the pull request to modify.
		/// </summary>
		public ID PullRequestId { get; set; }

		/// <summary>
		/// The Node IDs of the user to request.
		/// </summary>
		public List<ID> UserIds { get; set; }

		/// <summary>
		/// The Node IDs of the team to request.
		/// </summary>
		public List<ID> TeamIds { get; set; }

		/// <summary>
		/// Add users to the set rather than replace.
		/// </summary>
		public bool? Union { get; set; }
	}
}
