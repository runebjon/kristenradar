using Kristenradar.Services.Interfaces;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Kristenradar.Services
{
    public class RadarService : IRadarService
    {
        private readonly BehaviorSubject<int> _radarSubject = new(127);
        private readonly BehaviorSubject<bool> _isEnabledSubject = new(false);
        private readonly BehaviorSubject<bool> _isWarningSubject = new(false);

        public IObservable<int> RadarValueObservable => _radarSubject.AsObservable();
        public int RadarValue
        {
            get => _radarSubject.Value;
            set => _radarSubject.OnNext(value);
        }

        public IObservable<bool> IsEnabledObservable => _isEnabledSubject.AsObservable();
        public bool IsEnabled
        {
            get => _isEnabledSubject.Value;
            set => _isEnabledSubject.OnNext(value);
        }

        public IObservable<bool> IsWarningObservable => _isWarningSubject.AsObservable();
        public bool IsWarning
        {
            get => _isWarningSubject.Value;
            set => _isWarningSubject.OnNext(value);
        }

        public void Reset()
        {
            RadarValue = 127;
            IsEnabled = false;
            IsWarning = false;
        }
    }
}
