namespace CommandParam
{
    public class Command1 : CommandBase
    {
        public override bool CanExecute(object parameter)
        {
            if (ParameterHelper.TryGetParameters(parameter, out int int1) == false)
            {
                return false;
            }

            if (int1 >= 5)
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
