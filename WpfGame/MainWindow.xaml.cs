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
            TestJson();
        }
      
        //private bool _isUpdating = false;

        private void SetCharacter(string imagePath, string position)
        {
            
            imgCharacterLeft.Visibility = Visibility.Collapsed;
            imgCharacterRight.Visibility = Visibility.Collapsed;
            if (string.IsNullOrEmpty(imagePath)) return;
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", imagePath);
            var bitmap = new BitmapImage(new Uri(path, UriKind.Absolute));
            if (position == "left")
            {
                imgCharacterLeft.Source = bitmap;
                imgCharacterLeft.Visibility = Visibility.Visible;
            }
            else if (position == "right") 
            {
                imgCharacterRight.Source = bitmap;
                imgCharacterRight.Visibility = Visibility.Visible;
            }

        }
        private void ShowScene(string sceneId)
        {
            //_isUpdating = true;
            //MessageBox.Show($"{sceneId}");
            _currentScene = _scenes[sceneId];
            txtStory.Text = _currentScene.Text;
            SetBackground(_currentScene.Background);
            SetCharacter(_currentScene.characterImage, _currentScene.CharacterPosition);
            choicesList.Items.Clear();
            foreach (var choice in _currentScene.Choices)
            {
                choicesList.Items.Add(new ListBoxItem
                {
                    Content = $"{choice.Label}",
                    Tag = choice.NextSceneId,
                });
            }
            //_isUpdating = false;
        }
        private void TestJson()
        {
            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"GameData.json");
            string path = @"C:\vs npogpamu\-1\WpfGame\bin\Debug\GameData.json";
            //string path = @"C:\Users\Lenovo\Documents\GitHub\-1\WpfGame\bin\Debug\GameData.json";//комп макса
            //string path = @"C:\Users\Сева\Downloads\Telegram Desktop\game_story.json";

            //MessageBox.Show(path); // ← смотрим куда смотрит программа

            var (scenes, menu) = StoryLoader.Load(path);
            _scenes = scenes;
            ShowScene("Системный сбой");


            // Проверка — выводим ID всех сцен
            foreach (var key in _scenes.Keys)
            {
                System.Diagnostics.Debug.WriteLine(key);
                
            }
        }
        private void SetBackground(string imgName)
        {
            if (string.IsNullOrEmpty(imgName)) return;
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"assets",imgName);
            imgBackground.Source = new BitmapImage(new Uri(path,UriKind.Absolute));
        }
        private void choicesList_Click(object sender, MouseButtonEventArgs e)
        {

            var item = choicesList.SelectedItem as ListBoxItem;
            if (item == null) return;

            string nextId = item.Tag.ToString();
            choicesList.SelectedItem = null;
            ShowScene(nextId);
        }
        /*private void choicesList_SelectionChanged(object sender , SelectionChangedEventArgs e)
        {
            if (_isUpdating) return;
            var item = choicesList.SelectedItem as ListBoxItem;
            if (item == null) return;
            string nextId = item.Tag.ToString();
            //MessageBox.Show($"'{nextId}'");  // ← что пытаемся открыть
            choicesList.SelectedItem = null; 
            ShowScene(nextId);
        }*/
    }
}

