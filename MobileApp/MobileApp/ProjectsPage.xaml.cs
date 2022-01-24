using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public List<string> Projects { get; set; }
        public ProjectsPage()
        {
            Projects = new List<string>();
            string[] projects = new string[] { "Project 1", "Project 2", "Project 3", "Project 4",
                "Project 5", "Project 6", "Project 7", "Project 8", "Project 9", "Project 10", "Project 11" };

            for (int i = 0; i < projects.Length; i++)
            {
                Projects.Add(projects[i]);
            }

            this.BindingContext = this;

            InitializeComponent();
        }

        private async void projects_List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                await Navigation.PushAsync(new ProjectPage(e.SelectedItem.ToString()));
        }
    }
}