using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestCommand
{
    public class Person
    {
        public string Name { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        public List<Person> Persons { get; set; } = new List<Person>() { new Person() { Name = "Glenn Versweyveld" }, new Person() { Name = "John Do" } };

        private Command<Person> _doCommand;
        public Command<Person> DoCommand => _doCommand ?? (_doCommand = new Command<Person>((Person obj) => HandlePerson(obj)));

        private void HandlePerson(Person obj)
        {

        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}