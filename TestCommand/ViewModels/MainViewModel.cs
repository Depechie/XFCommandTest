using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestCommand.Models;
using Xamarin.Forms;

namespace TestCommand.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Person> Persons { get; set; } = new List<Person>() { new Person() { Name = "Glenn Versweyveld" }, new Person() { Name = "John Do" } };

        private Command<Person> _doCommand;
        public Command<Person> DoCommand => _doCommand ?? (_doCommand = new Command<Person>((Person obj) => HandlePerson(obj)));

        public MainViewModel()
        {
        }

        private void HandlePerson(Person obj)
        {

        }
    }
}