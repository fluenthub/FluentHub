using FluentHub.Uwp.Services;
using FluentHub.Uwp.Utils;
using FluentHub.Uwp.ViewModels.Home;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;

namespace FluentHub.Uwp.Views.Home
{
    public sealed partial class NotificationsPage : Page
    {
        public NotificationsPage()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<NotificationsViewModel>();
        }

        public NotificationsViewModel ViewModel { get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var command = ViewModel.LoadUserNotificationsPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }

        private void OnScrollViewerViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
                var command = ViewModel.LoadFurtherUserNotificationsPageCommand;
                if (command.CanExecute(null))
                    command.Execute(null);
            }
        }
    }
}
