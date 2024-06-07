// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A review comment associated with a given repository pull request.
	/// </summary>
	public class PullRequestReviewComment
	{
		/// <summary>
		/// The actor who authored the comment.
		/// </summary>
		public IActor Author { get; set; }

		/// <summary>
		/// Author's association with the subject of the comment.
		/// </summary>
		public CommentAuthorAssociation AuthorAssociation { get; set; }

		/// <summary>
		/// The comment body of this review comment.
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// The body rendered to HTML.
		/// </summary>
		public string BodyHTML { get; set; }

		/// <summary>
		/// The comment body of this review comment rendered as plain text.
		/// </summary>
		public string BodyText { get; set; }

		/// <summary>
		/// Identifies the commit associated with the comment.
		/// </summary>
		public Commit Commit { get; set; }

		/// <summary>
		/// Identifies when the comment was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the comment was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// Check if this comment was created via an email reply.
		/// </summary>
		public bool CreatedViaEmail { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"`databaseId` will be removed because it does not support 64-bit signed integer identifiers. Use `fullDatabaseId` instead. Removal on 2024-07-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The diff hunk to which the comment applies.
		/// </summary>
		public string DiffHunk { get; set; }

		/// <summary>
		/// Identifies when the comment was created in a draft state.
		/// </summary>
		public DateTimeOffset DraftedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the comment was created in a draft state."
		/// <summary>
		public string DraftedAtHumanized { get; set; }

		/// <summary>
		/// The actor who edited the comment.
		/// </summary>
		public IActor Editor { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the PullRequestReviewComment object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Check if this comment was edited and includes an edit with the creation data
		/// </summary>
		public bool IncludesCreatedEdit { get; set; }

		/// <summary>
		/// Returns whether or not a comment has been minimized.
		/// </summary>
		public bool IsMinimized { get; set; }

		/// <summary>
		/// The moment the editor made the last edit
		/// </summary>
		public DateTimeOffset? LastEditedAt { get; set; }

		/// <summary>
		/// Humanized string of "The moment the editor made the last edit"
		/// <summary>
		public string LastEditedAtHumanized { get; set; }

		/// <summary>
		/// The end line number on the file to which the comment applies
		/// </summary>
		public int? Line { get; set; }

		/// <summary>
		/// Returns why the comment was minimized. One of `abuse`, `off-topic`, `outdated`, `resolved`, `duplicate` and `spam`. Note that the case and formatting of these values differs from the inputs to the `MinimizeComment` mutation.
		/// </summary>
		public string MinimizedReason { get; set; }

		/// <summary>
		/// Identifies the original commit associated with the comment.
		/// </summary>
		public Commit OriginalCommit { get; set; }

		/// <summary>
		/// The end line number on the file to which the comment applied when it was first created
		/// </summary>
		public int? OriginalLine { get; set; }

		/// <summary>
		/// The original line index in the diff to which the comment applies.
		/// </summary>
		[Obsolete(@"We are phasing out diff-relative positioning for PR comments Removal on 2023-10-01 UTC.")]
		public int OriginalPosition { get; set; }

		/// <summary>
		/// The start line number on the file to which the comment applied when it was first created
		/// </summary>
		public int? OriginalStartLine { get; set; }

		/// <summary>
		/// Identifies when the comment body is outdated
		/// </summary>
		public bool Outdated { get; set; }

		/// <summary>
		/// The path to which the comment applies.
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// The line index in the diff to which the comment applies.
		/// </summary>
		[Obsolete(@"We are phasing out diff-relative positioning for PR comments Use the `line` and `startLine` fields instead, which are file line numbers instead of diff line numbers Removal on 2023-10-01 UTC.")]
		public int? Position { get; set; }

		/// <summary>
		/// Identifies when the comment was published at.
		/// </summary>
		public DateTimeOffset? PublishedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the comment was published at."
		/// <summary>
		public string PublishedAtHumanized { get; set; }

		/// <summary>
		/// The pull request associated with this review comment.
		/// </summary>
		public PullRequest PullRequest { get; set; }

		/// <summary>
		/// The pull request review associated with this review comment.
		/// </summary>
		public PullRequestReview PullRequestReview { get; set; }

		/// <summary>
		/// A list of reactions grouped by content left on the subject.
		/// </summary>
		public List<ReactionGroup> ReactionGroups { get; set; }

		/// <summary>
		/// A list of Reactions left on the Issue.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="content">Allows filtering Reactions by emoji.</param>
		/// <param name="orderBy">Allows specifying the order in which reactions are returned.</param>
		public ReactionConnection Reactions { get; set; }

		/// <summary>
		/// The comment this is a reply to.
		/// </summary>
		public PullRequestReviewComment ReplyTo { get; set; }

		/// <summary>
		/// The repository associated with this node.
		/// </summary>
		public Repository Repository { get; set; }

		/// <summary>
		/// The HTTP path permalink for this review comment.
		/// </summary>
		public string ResourcePath { get; set; }

		/// <summary>
		/// The start line number on the file to which the comment applies
		/// </summary>
		public int? StartLine { get; set; }

		/// <summary>
		/// Identifies the state of the comment.
		/// </summary>
		public PullRequestReviewCommentState State { get; set; }

		/// <summary>
		/// The level at which the comments in the corresponding thread are targeted, can be a diff line or a file
		/// </summary>
		public PullRequestReviewThreadSubjectType SubjectType { get; set; }

		/// <summary>
		/// Identifies when the comment was last updated.
		/// </summary>
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the comment was last updated."
		/// <summary>
		public string UpdatedAtHumanized { get; set; }

		/// <summary>
		/// The HTTP URL permalink for this review comment.
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// A list of edits to this content.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		public UserContentEditConnection UserContentEdits { get; set; }

		/// <summary>
		/// Check if the current viewer can delete this object.
		/// </summary>
		public bool ViewerCanDelete { get; set; }

		/// <summary>
		/// Check if the current viewer can minimize this object.
		/// </summary>
		public bool ViewerCanMinimize { get; set; }

		/// <summary>
		/// Can user react to this subject
		/// </summary>
		public bool ViewerCanReact { get; set; }

		/// <summary>
		/// Check if the current viewer can update this object.
		/// </summary>
		public bool ViewerCanUpdate { get; set; }

		/// <summary>
		/// Reasons why the current viewer can not update this comment.
		/// </summary>
		public List<CommentCannotUpdateReason> ViewerCannotUpdateReasons { get; set; }

		/// <summary>
		/// Did the viewer author this comment.
		/// </summary>
		public bool ViewerDidAuthor { get; set; }
	}
}
