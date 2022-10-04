using FluentHub.Uwp.Helpers;
using FluentHub.Uwp.Services;
using FluentHub.Uwp.Models;
using FluentHub.Uwp.Utils;
using FluentHub.Uwp.ViewModels.UserControls.Labels;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Uwp;

namespace FluentHub.Uwp.ViewModels.UserControls.Overview
{
    public class OrganizationProfileOverviewViewModel : ObservableObject
    {
        #region Fields and Properties
        private Organization _organization;
        public Organization Organization { get => _organization; set => SetProperty(ref _organization, value); }

        public static Organization StoredOrganization;

        private Uri _builtWebsiteUrl;
        public Uri BuiltWebsiteUrl { get => _builtWebsiteUrl; set => SetProperty(ref _builtWebsiteUrl, value); }

        private string _selectedTag;
        public string SelectedTag { get => _selectedTag; set => SetProperty(ref _selectedTag, value); }
        #endregion
    }
}
