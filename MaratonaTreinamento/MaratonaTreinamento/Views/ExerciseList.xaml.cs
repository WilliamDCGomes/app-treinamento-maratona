using System;
using System.Collections.Generic;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class ExerciseList : ContentPage
    {
        private ExerciseListViewModel _exerciseListViewMode;
        public ExerciseList()
        {
            InitializeComponent();
            _exerciseListViewMode = new ExerciseListViewModel();
            BindingContext = _exerciseListViewMode;
        }
    }
}
