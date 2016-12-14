using OpenTK;
using OpenTK.Graphics;
using BMSCube.src.ViewModel;
using System;
using System.Windows;

namespace BMSCube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseMainWindowViewModel m_viewModel;

        public MainWindow()
        {
            m_viewModel = new BaseMainWindowViewModel();
            DataContext = m_viewModel;
            InitializeComponent();
        }
    }
}
