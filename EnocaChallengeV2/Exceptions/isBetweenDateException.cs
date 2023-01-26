namespace EnocaChallengeV2.Exceptions
{
    public class isBetweenDateException : Exception
    {
        public isBetweenDateException()
       : base("Firma bu saatler içerisinde sipariş almıyor.")
        {
        }
    }
}
