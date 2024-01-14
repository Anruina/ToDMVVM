using ToDMVVM.MVVM.Models;
using ToDMVVM.MVVM.ViewModels;

namespace ToDMVVM.MVVM.Views;

public partial class ListQuestionPage : ContentPage
{
	public ListQuestionPage()
	{
		InitializeComponent();

		QuestionDataViewModel QuestionListViewModel = new QuestionDataViewModel();
		QuestionListView.ItemsSource = QuestionListViewModel.Questions;

		

		List<string> CategoryNames = new List<string>();

		foreach (Category category in QuestionListViewModel.Categories)
		{
			CategoryNames.Add(category.Title);
		}

        ChooseCategory.ItemsSource = CategoryNames;

		CreateQuestionButton.Command = QuestionListViewModel.CreateQuestionCommand;


    }
}