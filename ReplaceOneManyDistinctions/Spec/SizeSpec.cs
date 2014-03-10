namespace ReplaceOneManyDistinctions.Spec
{
   public class SizeSpec : ISpec
   {
      private readonly ProductSize _size;

      public SizeSpec( ProductSize size )
      {
         _size = size;
      }

      public bool IsSatisfiedBy( Product product )
      {
         return product.Size == _size;
      }
   }
}
