using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EpubReader
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            //初始化WinUI组件
            this.InitializeComponent();

            //隐藏默认的标题栏
            this.ExtendsContentIntoTitleBar = true;

            //设置标题栏
            this.SetTitleBar(TitleBar);
        }

        private void ToggleChapterList(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleFullScreen(object sender, RoutedEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChapterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
