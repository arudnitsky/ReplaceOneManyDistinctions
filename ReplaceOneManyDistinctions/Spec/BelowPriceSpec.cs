namespace ReplaceOneManyDistinctions.Spec
{
   public class BelowPriceSpec : ISpec
   {
      private readonly double _price;

      public BelowPriceSpec( double price )
      {
         _price = price;
      }

      public bool IsSatisfiedBy( Product product )
      {
         return product.Price < _price;
      }
   }
}
