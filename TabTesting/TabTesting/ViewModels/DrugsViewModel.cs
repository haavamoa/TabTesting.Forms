using System.ComponentModel;
using System.Runtime.CompilerServices;
using TabTesting.Models;

namespace TabTesting.ViewModels
{
    public class DrugsViewModel : INotifyPropertyChanged
    {
        private Age m_age;

        public void Initialize(Age age)
        {
            m_age = age;
        }

        public string Value
        {
            get => m_age?.Value;
            set
            {
                m_age.Value = value;
                OnPropertyChanged();
            }
        }

        public string Unit
        {
            get => m_age?.Unit;
            set
            {
                m_age.Unit = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Recalculate()
        {
        }
    }
}