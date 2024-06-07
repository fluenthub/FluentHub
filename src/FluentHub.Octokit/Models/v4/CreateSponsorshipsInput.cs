// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of CreateSponsorships
	/// </summary>
	public class CreateSponsorshipsInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The username of the user or organization who is acting as the sponsor, paying for the sponsorships.
		/// </summary>
		public string SponsorLogin { get; set; }

		/// <summary>
		/// The list of maintainers to sponsor and for how much apiece.
		/// </summary>
		public List<BulkSponsorship> Sponsorships { get; set; }

		/// <summary>
		/// Whether the sponsor should receive email updates from the sponsorables.
		/// </summary>
		public bool? ReceiveEmails { get; set; }

		/// <summary>
		/// Specify whether others should be able to see that the sponsor is sponsoring the sponsorables. Public visibility still does not reveal the dollar value of the sponsorship.
		/// </summary>
		public SponsorshipPrivacy? PrivacyLevel { get; set; }

		/// <summary>
		/// Whether the sponsorships created should continue each billing cycle for the sponsor (monthly or annually), versus lasting only a single month. Defaults to one-time sponsorships.
		/// </summary>
		public bool? Recurring { get; set; }
	}
}
