﻿using FluentHub.Helpers;
using FluentHub.Services;
using FluentHub.Services.Auth;
using FluentHub.ViewModels;
using FluentHub.Views;
using FluentHub.Views.SignInPages;
using Octokit;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace FluentHub
{
    sealed partial class App : Windows.UI.Xaml.Application
    {
        Frame rootFrame = Window.Current.Content as Frame;

        public static GitHubClient Client { get; private set; } = new GitHubClient(new ProductHeaderValue("FluentHub"));

        public static MainViewModel MainViewModel { get; private set; } = new MainViewModel();

        public static SettingsViewModel Settings { get; private set; } = new SettingsViewModel();

        public static string DefaultHost { get; private set; } = "https://github.com";

        public static string RestApiEndPoint { get; private set; } = "https://api.github.com";

        public static string GraphQlApiEndPoint { get; private set; } = "https://api.github.com/graphql";

        public static string SignedInUserName { get; private set; }

        private static InternetConnectionHelpers internetConnection = new InternetConnectionHelpers();

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            

            if (Settings.SetupCompleted == true)
            {
                if (Settings.Get("AccessToken", "") != "")
                {
                    Client.Credentials = new Credentials(Settings.Get("AccessToken", ""));
                }
                else
                {
                    Settings.SetupProgress = false;
                    Settings.SetupCompleted = false;

                    rootFrame.Navigate(typeof(IntroPage));
                }
            }
        }

        private void IntializeLogger()
        {
            string logFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Logs/Log.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Debug("Initialized logger.");
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationView.GetForCurrentView().TitleBar.ButtonBackgroundColor = Colors.Transparent;
            ApplicationView.GetForCurrentView().TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    if (Settings.SetupCompleted == true)
                    {
                        User user = await Client.User.Current();
                        SignedInUserName = user.Login;
                    }

                    Log.Information("FluentHub has been launched.");

                    IntializeLogger();

                    _ = !Settings.SetupCompleted ?
                        rootFrame.Navigate(typeof(IntroPage), e.Arguments) :
                        rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                ThemeHelper.Initialize();

                Window.Current.Activate();
            }
        }

        protected async override void OnActivated(IActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.Protocol)
            {
                if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                {
                    await HandleProtocolActivationArguments(args);
                }
            }
        }

        private async Task HandleProtocolActivationArguments(IActivatedEventArgs args)
        {
            ProtocolActivatedEventArgs eventArgs = args as ProtocolActivatedEventArgs;
            string code = new WwwFormUrlDecoder(eventArgs.Uri.Query).GetFirstValueByName("code");

            if (code != null)
            {
                RequestAuthorization auth = new RequestAuthorization();

                // Request token with code
                bool status = await auth.RequestOAuthToken(code);

                if (status)
                {
                    User user = await Client.User.Current();
                    SignedInUserName = user.Login;

                    rootFrame.Navigate(typeof(MainPage));
                }
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        public static TEnum GetEnum<TEnum>(string text) where TEnum : struct
        {
            if (!typeof(TEnum).GetTypeInfo().IsEnum)
            {
                throw new InvalidOperationException("Generic parameter 'TEnum' must be an enum.");
            }
            return (TEnum)Enum.Parse(typeof(TEnum), text);
        }

        public static async void CloseApp()
        {
            if (!await ApplicationView.GetForCurrentView().TryConsolidateAsync())
            {
                Current.Exit();
            }
        }
    }
}