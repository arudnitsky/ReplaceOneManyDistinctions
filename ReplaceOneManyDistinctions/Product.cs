namespace ReplaceOneManyDistinctions
{
   public class Product
   {
      public string Description { get; set; }
      public string ProductCode { get; set; }
      public double Price { get; set; }
      public ProductSize Size { get; set; }
      public ProductColor Color { get; set; }
   }

   public enum ProductSize
   {
      Small, Medium, Large, NotApplicable
   }

   public enum ProductColor
   {
      Red, White, Pink, Yellow
   }
}
