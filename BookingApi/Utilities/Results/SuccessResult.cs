namespace BookingApi.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(String message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}

