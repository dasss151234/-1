using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGame
{

    public partial class MainWindow : Window
    {
        private Scene _currentScene;
        private Dictionary<string, Scene> _scenes;
        public MainWindow()
        {
            InitializeComponent();
            //TestJson();
            TestScene();
        }
        private void ShowScene(string sceneId)
        {
           _currentScene = _scenes[sceneId];
            txtStory.Text = _currentScene.Text;
            SetBackground(_currentScene.Background);
            choicesList.Items.Clear();
            foreach (var choice in _currentScene.Choices)
            {
                choicesList.Items.Add(new ListBoxItem
                {
                    Content = $"{choice.Label}",
                    Tag = choice.NextSceneId,
                });
            }
        }
        private void TestScene()
        {
            ShowScene("Системный сбой");
        }
        private void TestJson()
        {
            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"GameData.json");
            string path = @"C:\vs npogpamu\-1\WpfGame\bin\Debug\GameData.json";

            MessageBox.Show(path); // ← смотрим куда смотрит программа

            _scenes = StoryLoader.Load(path);
            ShowScene("start");


            // Проверка — выводим ID всех сцен
            foreach (var key in _scenes.Keys)
            {
                System.Diagnostics.Debug.WriteLine(key);

            }
        }
        private void SetBackground(string path)
        {
            if (string.IsNullOrEmpty(path)) return;
            imgBackground.Source = new BitmapImage(new Uri(path, UriKind.Relative));

        }
        private void choicesList_SelectionChanged(object sender , SelectionChangedEventArgs e)
        {
            if (!(choicesList.SelectedItem is ListBoxItem item))return;
            string nextId = item.Tag.ToString();
            choicesList.SelectedItem = null;
            ShowScene(nextId);
        }
    }
}
