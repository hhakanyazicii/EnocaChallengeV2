namespace EnocaChallengeV2.Exceptions
{
    
    public class isVerifiedException : Exception
    {
        public isVerifiedException()
       : base("Firma onaylı olmadığı için sipariş veremezsiniz.")
        {
        }
    }
}
