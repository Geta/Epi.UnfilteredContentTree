using EPiServer.Core;
using EPiServer.Shell;
using EPiServer.Shell.ViewComposition;

namespace Geta.Epi.UnfilteredContentTree
{
    [Component]
    public class UnfilteredContentTreeComponent : ComponentDefinitionBase
    {
        private string _title;

        public UnfilteredContentTreeComponent() : base("epi-cms/component/MainNavigationComponent")
        {
            LanguagePath = "/episerver/cms/components/pagetree";

            PlugInAreas = new[]
            {
                PlugInArea.Assets,
                PlugInArea.Navigation
            };

            Categories = new[] { "content" };

            SortOrder = 120;
            AllowedRoles.Add("Administrators");
            AllowedRoles.Add("CmsAdmins");
            Settings.Add(new Setting("repositoryKey", AllContentRepositoryDescriptor.RepositoryKey));
            Settings.Add(new Setting("allowedTypes", new[] { typeof(ContentData) }));
        }

        public override string Title
        {
            get
            {
                string title = LocalizationService.GetString("/geta/components/unfilteredcontenttree/title");

                if (string.IsNullOrEmpty(title) == false)
                    return title;

                return _title;
            }
            set
            {
                _title = value;
            }
        }
    }
}