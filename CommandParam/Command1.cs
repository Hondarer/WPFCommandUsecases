namespace CommandParam
{
    public class Command1 : CommandBase
    {
        public override bool CanExecute(object parameter)
        {
            if (!(parameter is int))
            {
                return false;
            }

            if ((int)parameter > 5)
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
