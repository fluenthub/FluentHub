// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of EnablePullRequestAutoMerge
	/// </summary>
	public class EnablePullRequestAutoMergeInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// ID of the pull request to enable auto-merge on.
		/// </summary>
		public ID PullRequestId { get; set; }

		/// <summary>
		/// Commit headline to use for the commit when the PR is mergable; if omitted, a default message will be used. NOTE: when merging with a merge queue any input value for commit headline is ignored.
		/// </summary>
		public string CommitHeadline { get; set; }

		/// <summary>
		/// Commit body to use for the commit when the PR is mergable; if omitted, a default message will be used. NOTE: when merging with a merge queue any input value for commit message is ignored.
		/// </summary>
		public string CommitBody { get; set; }

		/// <summary>
		/// The merge method to use. If omitted, defaults to `MERGE`. NOTE: when merging with a merge queue any input value for merge method is ignored.
		/// </summary>
		public PullRequestMergeMethod? MergeMethod { get; set; }

		/// <summary>
		/// The email address to associate with this merge.
		/// </summary>
		public string AuthorEmail { get; set; }

		/// <summary>
		/// The expected head OID of the pull request.
		/// </summary>
		public string ExpectedHeadOid { get; set; }
	}
}
