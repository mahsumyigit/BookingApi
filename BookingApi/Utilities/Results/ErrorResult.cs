namespace BookingApi.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(String message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}

