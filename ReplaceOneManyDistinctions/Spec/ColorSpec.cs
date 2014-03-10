namespace ReplaceOneManyDistinctions.Spec
{
   public class ColorSpec : ISpec
   {
      private readonly ProductColor _color;

      public ColorSpec( ProductColor color )
      {
         _color = color;
      }

      public bool IsSatisfiedBy( Product product )
      {
         return product.Color == _color;
      }
   }
}
