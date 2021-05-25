using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class VisualizeExercise : ContentPage
    {
        private Exercise _exercise;
        public VisualizeExercise(Exercise exercise)
        {
            InitializeComponent();
            _exercise = exercise;
        }
    }
}
