﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using ExamplePracWork13.Classes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //список объектов класса ClassLibrary
            
            List<ClassLibrary> libraries = new List<ClassLibrary>();

            //один объект класса ClassLibrary
            ClassLibrary library = new ClassLibrary()
            {
                NumberReaderBillet = "0000001",
                FullName = "Абоба Равно Лайк",
                Adress = "Москва",
                Phone = "8 800 555 3535",
                TitleBook = "Разработчик игр абоба",
                DateIssue = DateTime.Now,
                DateReturn = DateTime.Now.AddDays(10)
            };
            libraries.Add(library);

            //источник данных таблицы - список объектов 
            DtgListBooks.ItemsSource= libraries;
        }
    }
}
