using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer.Cms.Shell.UI.CompositeViews.Internal;
using EPiServer.Cms.Shell.UI.UIDescriptors;
using EPiServer.Core;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;
using EPiServer.Shell;

namespace Geta.Epi.UnfilteredContentTree
{
    [ServiceConfiguration(typeof(IContentRepositoryDescriptor))]
    public class AllContentRepositoryDescriptor : ContentRepositoryDescriptorBase
    {
        public static string RepositoryKey = "all";

        public override string Key => RepositoryKey;

        public override string Name => LocalizationService.Current.GetString("/geta/components/unfilteredcontenttree/title");

        public override IEnumerable<Type> CreatableTypes => new[]
        {
            typeof (ContentData)
        };

        public override IEnumerable<Type> ContainedTypes => new[]
        {
            typeof (ContentData)
        };

        public override IEnumerable<Type> LinkableTypes => new[]
        {
            typeof (ContentData)
        };

        public override IEnumerable<ContentReference> Roots => new[] { ContentReference.RootPage };

        public override IEnumerable<Type> MainNavigationTypes => new[]
        {
            typeof(ContentData)
        };

        public override IEnumerable<string> PreventDeletionFor => new []
        {
            ContentReference.StartPage.ToString(),
            ContentReference.RootPage.ToString(),
            ContentReference.WasteBasket.ToString()
        };

        public override IEnumerable<string> PreventCopyingFor => new []
        {
            ContentReference.RootPage.ToString(),
            ContentReference.WasteBasket.ToString()
        };

        public override IEnumerable<string> MainViews => new []
        {
            HomeView.ViewName
        };

        public override string SearchArea => "CMS/pages";
    }
}