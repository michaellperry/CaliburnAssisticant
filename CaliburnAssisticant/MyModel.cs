using Assisticant.Fields;

namespace CaliburnAssisticant
{
    public class MyModel
    {
        private Observable<string> _myModelProperty = new Observable<string>();

        public string MyModelProperty
        {
            get { return _myModelProperty.Value; }
            set { _myModelProperty.Value = value; }
        }
    }
}
