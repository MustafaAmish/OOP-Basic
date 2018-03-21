using System.Linq;
using Forum.App.Services;
using Forum.App.Views;

namespace Forum.App.Controllers
{
    using System;

    using Forum.App.Controllers.Contracts;
    using Forum.App.UserInterface.Contracts;

    public class CategoriesController : IController, IPaginationController
    {

        private enum Command
        {
            Back = 0,
            ViewCategory = 1,
            PreviousPage = 11,
            NextPage = 12
        }

        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        public int CurrentPage { get; set; }
        private string[] AllCategoryNames { get; set; }
        private string[] CurrentPageCategories { get; set; }
        private int LastPage => this.AllCategoryNames.Length / (PAGE_OFFSET + 1);
        private bool IsFirstPage => this.CurrentPage == 0;
        private bool IsLastPage => this.CurrentPage == this.LastPage;

        public CategoriesController()
        {
            CurrentPage = 0;
            LoadCategories();
        }

        private void ChangePage(bool forward = true)
        {
            this.CurrentPage += forward ? 1 : -1;
        }

        public MenuState ExecuteCommand(int index)
        {
            if (index > 1 && index < 11)
            {
                index = 1;
            }
            switch ((CategoriesController.Command)index)
            {
                case CategoriesController.Command.Back:
                    return MenuState.Back;
                case CategoriesController.Command.ViewCategory:
                    return MenuState.OpenCategory;
                case CategoriesController.Command.PreviousPage:
                    this.ChangePage(false);
                    return MenuState.Rerender;
                case CategoriesController.Command.NextPage:
                    this.ChangePage();
                    return MenuState.Rerender;
            }
            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            LoadCategories();
            return new CategoriesView(this.CurrentPageCategories, this.IsFirstPage, this.IsLastPage);
        }

        private void LoadCategories()
        {
            this.AllCategoryNames = PostService.GetAllCategoryNames();

            this.CurrentPageCategories = this.AllCategoryNames
                .Skip(this.CurrentPage * PAGE_OFFSET).Take(PAGE_OFFSET).ToArray();
        }
    }
}
