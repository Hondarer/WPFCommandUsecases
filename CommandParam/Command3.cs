namespace CommandParam
{
    public class Command3 : CommandBase
    {
        public override bool CanExecute(object parameter)
        {
            if (!(parameter is Command3Parameter))
            {
                return false;
            }

            Command3Parameter _parameter = parameter as Command3Parameter;

            if (_parameter.Int1 > 5)
            {
                return true;
            }

            return false;
        }

        public override void Execute(object parameter)
        {
        }
    }
}
