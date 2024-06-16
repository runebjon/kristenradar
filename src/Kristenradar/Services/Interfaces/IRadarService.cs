namespace Kristenradar.Services.Interfaces
{
    public interface IRadarService
    {
        IObservable<int> RadarValueObservable { get; }
        IObservable<bool> IsEnabledObservable { get; }
        IObservable<bool> IsWarningObservable { get; }
        int RadarValue { get; set; }
        bool IsEnabled { get; set; }
        bool IsWarning { get; set; }

        void Reset();
    }
}
