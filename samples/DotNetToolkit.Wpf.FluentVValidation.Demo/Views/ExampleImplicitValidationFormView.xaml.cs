﻿namespace DotNetToolkit.Wpf.FluentVValidation.Demo.Views
{
    using ViewModels;

    /// <summary>
    /// Interaction logic for ExampleExplicitValidationFormView.xaml
    /// </summary>
    public partial class ExampleImplicitValidationFormView
    {
        public ExampleImplicitValidationFormView()
        {
            InitializeComponent();

            DataContext = new ExampleImplicitValidationFormViewModel();
        }
    }
}
