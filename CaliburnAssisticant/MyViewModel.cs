using Assisticant.Fields;

namespace CaliburnAssisticant
{
    public class MyViewModel : Caliburn.Micro.PropertyChangedBase
    {
        private readonly MyModel _model;
        private Computed<string> _myProperty;
        private ComputedSubscription _myPropertySubscription;

        public MyViewModel(MyModel model)
        {
            _model = model;
            _myProperty = new Computed<string>(() => _model.MyModelProperty);
            _myPropertySubscription = _myProperty.Subscribe(_ =>
                NotifyOfPropertyChange(() => MyProperty));
        }

        public string MyProperty
        {
            get { return _myProperty.Value; }
            set { _model.MyModelProperty = value; }
        }
    }
}
